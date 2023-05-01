using Microsoft.EntityFrameworkCore;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;
using Microsoft.AspNetCore.Identity;
using keuzewijzer_hbo_deeltijd_ict_API.Models;
using Microsoft.AspNetCore.Identity;
using keuzewijzer_hbo_deeltijd_ict_API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<UserContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DbSettings")));

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<UserContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication(); // Enable authentication
app.UseAuthorization();

app.MapControllers();

app.Run();
