using keuzewijzer_hbo_deeltijd_ict_API.Controllers;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;
using keuzewijzer_hbo_deeltijd_ict_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace Keuzewijzer_hbo_deeltijd_ict_API.Tests.Controllers
{
    public class StudyRouteControllerTests : IDisposable
    {
        private StudyRouteController _controller;
        private DbContextOptions<KeuzewijzerContext> _options;

        public StudyRouteControllerTests()
        {
            _options = new DbContextOptionsBuilder<KeuzewijzerContext>()
                .UseInMemoryDatabase(databaseName: "test_database")
                .Options;

            _controller = new StudyRouteController(new KeuzewijzerContext(_options));
        }

        public void Dispose()
        {
            using (var context = new KeuzewijzerContext(_options))
            {
                var studyRoute = context.StudyRoutes.FirstOrDefault(item => item.Id == 1);
                if (studyRoute != null)
                {
                    context.StudyRoutes.Remove(studyRoute);
                    context.SaveChanges();
                }
            }
        }
        [Fact]
        public async Task PostStudyRoute_ValidData_ReturnsCreatedResponse()
        {
            // Arrange
            var studyRoute = new StudyRoute
            {
                UserId = "1",
                Note = "",
                StudyRouteItems = new List<StudyRouteItem>
                {
                    new StudyRouteItem { Id = 1, StudyRouteId = 1 },
                    new StudyRouteItem { Id = 2, StudyRouteId = 1 },
                    new StudyRouteItem { Id = 3, StudyRouteId = 1 },
                    new StudyRouteItem { Id = 4, StudyRouteId = 1 },
                    new StudyRouteItem { Id = 5, StudyRouteId = 1 },
                    new StudyRouteItem { Id = 6, StudyRouteId = 1 },
                    new StudyRouteItem { Id = 7, StudyRouteId = 1 },
                    // Add more study route items as needed
                }
            };
          
            // Act
            var result = await _controller.PostStudyRoute(studyRoute);

            // Assert
            Assert.IsType<ActionResult<StudyRoute>>(result);
            
            var createdResult = Assert.IsType<CreatedAtActionResult>(result.Result);
            Assert.Equal("GetStudyRoute", createdResult.ActionName);
            Assert.Equal(studyRoute.Id, createdResult.RouteValues["id"]);
            Assert.Equal(studyRoute, createdResult.Value);

            // Additional assertions to verify the data in the actual database
            using (var context = new KeuzewijzerContext(_options))
            {
                var savedStudyRoute = await context.StudyRoutes.FindAsync(studyRoute.Id);
                Assert.NotNull(savedStudyRoute);
                Assert.Equal(studyRoute.UserId, savedStudyRoute.UserId);
                // Assert other properties and relationships as needed
            }
        }

        [Fact]
        public async Task PostStudyRoute_LessThen7StudyRouteItems_ReturnsBadRequest()
        {
            // Arrange
            var studyRoute = new StudyRoute
            {
                UserId = "1",
                Note = "",
                StudyRouteItems = new List<StudyRouteItem>
                {
                    new StudyRouteItem { Id = 1, StudyRouteId = 1 },
                    new StudyRouteItem { Id = 2, StudyRouteId = 1 },
                    new StudyRouteItem { Id = 3, StudyRouteId = 1 },
                    new StudyRouteItem { Id = 4, StudyRouteId = 1 },
                    new StudyRouteItem { Id = 5, StudyRouteId = 1 },
                }
            };

            // Act
            var result = await _controller.PostStudyRoute(studyRoute);

            // Assert
            Assert.IsType<ActionResult<StudyRoute>>(result);
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }

    }
}