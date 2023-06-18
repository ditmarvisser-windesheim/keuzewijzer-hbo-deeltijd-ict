using keuzewijzer_hbo_deeltijd_ict_API.Controllers;
using keuzewijzer_hbo_deeltijd_ict_API.Models;
using keuzewijzer_hbo_deeltijd_ict_API.Request;
using keuzewijzer_hbo_deeltijd_ict_API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moq;
using Microsoft.AspNetCore.Http.Extensions;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;
using Microsoft.EntityFrameworkCore;

namespace keuzewijzer_hbo_deeltijd_ict_API_test
{
    public class IdentityAuthenticationTest
    {
        [Fact]
        public async Task Login_Succes()
        {
            // Arrange
            var testUser = GetTestUser();
            var store = new Mock<IUserStore<User>>();

            var userManagerMock = new Mock<UserManager<User>>(store.Object, null, null, null, null, null, null, null, null);
            userManagerMock.Setup(u => u.FindByEmailAsync(It.IsAny<string>()))
                .ReturnsAsync(testUser);
            userManagerMock.Setup(u => u.GetRolesAsync(testUser))
                .ReturnsAsync(new List<string> { "Administrator" });

            var signInManagerMock = MockSignInManager<User>(userManagerMock.Object);
            signInManagerMock.Setup(sm => sm.CheckPasswordSignInAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<bool>()))
                .ReturnsAsync(Microsoft.AspNetCore.Identity.SignInResult.Success);

            var authController = new AuthController(userManagerMock.Object, signInManagerMock.Object);
            var loginRequest = new LoginRequest { UserName = "admin@example.com", Password = "welkom" };

            // Mock the HttpContext and set the authentication cookie
            var httpContext = new DefaultHttpContext();
            var services = new ServiceCollection();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.Events.OnRedirectToLogin = (context) =>
                    {
                        context.Response.StatusCode = 401;
                        return Task.CompletedTask;
                    };
                });
            services.AddLogging();
            httpContext.RequestServices = services.BuildServiceProvider();

            httpContext.Request.Headers["Host"] = "localhost";
            authController.ControllerContext = new ControllerContext
            {
                HttpContext = httpContext
            };

            // Act
            var result = await authController.Login(loginRequest);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = (OkObjectResult)result;
            Assert.IsType<AuthenticationResponse>(okResult.Value);

            var cookies = httpContext.Response.Headers.FirstOrDefault(x => x.Key == "Set-Cookie");
            Assert.NotNull(cookies);
        }
 

        [Fact]
        public async Task Login_Wrong_Password()
        {
            // Arrange
            var testUser = GetTestUser();
            var store = new Mock<IUserStore<User>>();

            var userManagerMock = new Mock<UserManager<User>>(store.Object, null, null, null, null, null, null, null, null);
            userManagerMock.Setup(u => u.FindByEmailAsync(It.IsAny<string>()))
                .ReturnsAsync(testUser);
            userManagerMock.Setup(u => u.GetRolesAsync(testUser))
                .ReturnsAsync(new List<string> { "Administrator" });

            var signInManagerMock = MockSignInManager<User>(userManagerMock.Object);
            signInManagerMock.Setup(sm => sm.CheckPasswordSignInAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<bool>()))
                .ReturnsAsync(Microsoft.AspNetCore.Identity.SignInResult.Failed);

            var authController = new AuthController(userManagerMock.Object, signInManagerMock.Object);
            var loginRequest = new LoginRequest { UserName = "admin@example.com", Password = "ditisfout" };

            // Mock the HttpContext and set the authentication cookie
            var httpContext = new DefaultHttpContext();
            var services = new ServiceCollection();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.Events.OnRedirectToLogin = (context) =>
                    {
                        context.Response.StatusCode = 401;
                        return Task.CompletedTask;
                    };
                });
            services.AddLogging();
            httpContext.RequestServices = services.BuildServiceProvider();

            httpContext.Request.Headers["Host"] = "localhost";
            authController.ControllerContext = new ControllerContext
            {
                HttpContext = httpContext
            };

            // Act
            var result = await authController.Login(loginRequest);

            // Assert
            Assert.IsType<UnauthorizedResult>(result);

            var cookies = httpContext.Response.Cookies.ToString;
            Assert.Null(cookies);
        }

        [Fact]
        public async Task GetSBStudentsWithCorrectUser()
        {
            // Arrange

            var testUser = GetTestStudiebegeleiderUser1();

            var claims = new List<Claim>
            {
                new Claim(type: ClaimTypes.Email, value: testUser.Email),
                new Claim(type: ClaimTypes.Name,value: testUser.Name),
                new Claim(type: ClaimTypes.Sid,value: testUser.Id),
                new Claim(type: ClaimTypes.Role, value: "Administrator")
            };


            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var claimsPrincipal = new ClaimsPrincipal(identity);

            // Mock the HttpContext and set the authentication cookie
            var httpContext = new DefaultHttpContext();

            var services = new ServiceCollection();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.Events.OnRedirectToLogin = (context) =>
                    {
                        context.Response.StatusCode = 401;
                        return Task.CompletedTask;
                    };
                });
            services.AddLogging();
            httpContext.RequestServices = services.BuildServiceProvider();
            httpContext.User = claimsPrincipal;

            var store = new Mock<IUserStore<User>>();

            var _options = new DbContextOptionsBuilder<KeuzewijzerContext>()
                .UseInMemoryDatabase(databaseName: "test_database")
                .Options;

            var userManagerMock = new Mock<UserManager<User>>(store.Object, null, null, null, null, null, null, null, null);
            var _userController = new UserController(new KeuzewijzerContext(_options), userManagerMock.Object);
            _userController.ControllerContext = new ControllerContext { HttpContext= httpContext };

            // Act
            var result = await _userController.GetSBStudents("2");

            // Assert
            // If there is a result then the request is authorized
            Assert.NotNull(result.Value);
        }        
        
        [Fact]
        public async Task GetSBStudentsWithIncorrectUser()
        {
            // Arrange

            var testUser = GetTestStudiebegeleiderUser1();

            var claims = new List<Claim>
            {
                new Claim(type: ClaimTypes.Email, value: testUser.Email),
                new Claim(type: ClaimTypes.Name,value: testUser.Name),
                new Claim(type: ClaimTypes.Sid,value: testUser.Id),
                new Claim(type: ClaimTypes.Role, value: "Administrator")
            };


            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var claimsPrincipal = new ClaimsPrincipal(identity);

            // Mock the HttpContext and set the authentication cookie
            var httpContext = new DefaultHttpContext();

            var services = new ServiceCollection();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.Events.OnRedirectToLogin = (context) =>
                    {
                        context.Response.StatusCode = 401;
                        return Task.CompletedTask;
                    };
                });
            services.AddLogging();
            httpContext.RequestServices = services.BuildServiceProvider();
            httpContext.User = claimsPrincipal;

            var store = new Mock<IUserStore<User>>();

            var _options = new DbContextOptionsBuilder<KeuzewijzerContext>()
                .UseInMemoryDatabase(databaseName: "test_database")
                .Options;

            var userManagerMock = new Mock<UserManager<User>>(store.Object, null, null, null, null, null, null, null, null);
            var _userController = new UserController(new KeuzewijzerContext(_options), userManagerMock.Object);
            _userController.ControllerContext = new ControllerContext { HttpContext= httpContext };

            // Act
            var result = await _userController.GetSBStudents("3");

            // Assert
            // If there is no result then the request is authorized
            Assert.Null(result.Value);
        }

        private Mock<SignInManager<TUser>> MockSignInManager<TUser>(UserManager<TUser> userManager) where TUser : class
        {
            var contextAccessorMock = new Mock<IHttpContextAccessor>();
            var userPrincipalFactoryMock = new Mock<IUserClaimsPrincipalFactory<TUser>>();
            var signInManagerMock = new Mock<SignInManager<TUser>>(userManager, contextAccessorMock.Object, userPrincipalFactoryMock.Object, null, null, null, null);

            signInManagerMock.Setup(sm => sm.PasswordSignInAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>()))
                .ReturnsAsync(Microsoft.AspNetCore.Identity.SignInResult.Success);

            return signInManagerMock;
        }

        private User GetTestUser()
        {
            var passwordHasher = new PasswordHasher<User>();

            var user = new User
            {
                Id = "1",
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@example.com",
                NormalizedEmail = "admin@example.com",
                Name = "Arnold Dirk Min",
                FirstName = "Arnold",
                LastName = "Min",
                PasswordHash = passwordHasher.HashPassword(null, "welkom")
            };

            return user;
        }

        private User GetTestStudiebegeleiderUser1()
        {
            var passwordHasher = new PasswordHasher<User>();

            var user = new User
            {
                Id = "2",
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@example.com",
                NormalizedEmail = "admin@example.com",
                Name = "Arnold Dirk Min",
                FirstName = "Arnold",
                LastName = "Min",
                PasswordHash = passwordHasher.HashPassword(null, "welkom")
            };

            return user;
        }
        private User GetTestStudiebegeleiderUser2()
        {
            var passwordHasher = new PasswordHasher<User>();

            var user = new User
            {
                Id = "3",
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@example.com",
                NormalizedEmail = "admin@example.com",
                Name = "Arnold Dirk Min",
                FirstName = "Arnold",
                LastName = "Min",
                PasswordHash = passwordHasher.HashPassword(null, "welkom")
            };

            return user;
        }
    }
}
