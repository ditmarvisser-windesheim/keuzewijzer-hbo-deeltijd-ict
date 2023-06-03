using keuzewijzer_hbo_deeltijd_ict_API.Controllers;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;
using keuzewijzer_hbo_deeltijd_ict_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Keuzewijzer_hbo_deeltijd_ict_API.Tests.Controllers
{
    public class CohortControllerTests : IDisposable
    {
        private CohortController _controller;
        private DbContextOptions<KeuzewijzerContext> _options;

        public CohortControllerTests()
        {
            _options = new DbContextOptionsBuilder<KeuzewijzerContext>()
                .UseInMemoryDatabase(databaseName: "test_database")
                .Options;

            _controller = new CohortController(new KeuzewijzerContext(_options));
        }

        public void Dispose()
        {
            using (var context = new KeuzewijzerContext(_options))
            {
                var cohort = context.Cohorts.FirstOrDefault(item => item.Id == 1);
                if (cohort != null)
                {
                    context.Cohorts.Remove(cohort);
                    context.SaveChanges();
                }
            }
        }

        [Fact]
        public async Task GetCohort_ValidId_ReturnsCohort()
        {
            // Arrange
            using (var context = new KeuzewijzerContext(_options))
            {
                // Add test data to the in-memory database
                var cohort = new Cohort
                {
                    Id = 1,
                    Name = "Sample Name"
                };
                context.Cohorts.Add(cohort);
                context.SaveChanges();
            }

            // Act
            var result = await _controller.GetCohort(1);

            // Assert
            Assert.NotNull(result);
            var actionResult = Assert.IsType<ActionResult<Cohort>>(result);
            var returnedItem = Assert.IsType<Cohort>(actionResult.Value);

            Assert.Equal(1, returnedItem.Id);
            Assert.Equal("Sample Name", returnedItem.Name);
        }

        [Fact]
        public async Task GetCohort_InvalidId_ReturnsNotFound()
        {
            // Act
            var result = await _controller.GetCohort(1);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public async Task CreateCohort_ValidItem_ReturnsCreatedItem()
        {
            // Arrange
            var cohort = new Cohort
            {
                Id = 1,
                Name = "Sample Name"
            };

            // Act
            var result = await _controller.PostCohort(cohort);

            // Assert
            Assert.IsType<ActionResult<Cohort>>(result);

            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result.Result);
            Assert.Equal("GetCohort", createdAtActionResult.ActionName);
            Assert.Equal(cohort, createdAtActionResult.Value);

            using (var context = new KeuzewijzerContext(_options))
            {
                var createdItem = await context.Cohorts.FindAsync(1);
                Assert.NotNull(createdItem);
                Assert.Equal(1, createdItem.Id);
            }
        }

        [Fact]
        public async Task UpdateCohort_ValidItem_ReturnsNoContent()
        {
            // Arrange
            using (var context = new KeuzewijzerContext(_options))
            {
                // Add test data to the in-memory database
                var cohort = new Cohort
                {
                    Id = 1,
                    Name = "Sample Name"
                };
                context.Cohorts.Add(cohort);
                context.SaveChanges();
            }

            var updatedItem = new Cohort { Id = 1, Name = "Updated Name" };

            // Act
            var result = await _controller.PutCohort(1, updatedItem);

            // Assert
            Assert.IsType<NoContentResult>(result);

            using (var context = new KeuzewijzerContext(_options))
            {
                var existingItem = await context.Cohorts.FindAsync(1);
                Assert.NotNull(existingItem);
                Assert.Equal(updatedItem.Id, existingItem.Id);
                Assert.Equal(updatedItem.Name, existingItem.Name);
            }
        }

        [Fact]
        public async Task UpdateCohort_InvalidId_ReturnsNotFound()
        {
            // Arrange
            var updatedItem = new Cohort { Id = 1, Name = "Updated Name" };

            // Act
            var result = await _controller.PutCohort(1, updatedItem);

            // Assert
            Assert.IsType<NotFoundResult>(result);

            using (var context = new KeuzewijzerContext(_options))
            {
                var existingItem = await context.Cohorts.FindAsync(1);
                Assert.Null(existingItem);
            }
        }

        [Fact]
        public async Task DeleteCohort_ValidId_ReturnsNoContent()
        {
            // Arrange
            using (var context = new KeuzewijzerContext(_options))
            {
                // Add test data to the in-memory database
                var cohort = new Cohort
                {
                    Id = 1,
                    Name = "Sample Name"
                };
                context.Cohorts.Add(cohort);
                context.SaveChanges();
            }

            // Act
            var result = await _controller.DeleteCohort(1);

            // Assert
            Assert.IsType<NoContentResult>(result);

            using (var context = new KeuzewijzerContext(_options))
            {
                var existingItem = await context.Cohorts.FindAsync(1);
                Assert.Null(existingItem);
            }
        }

        [Fact]
        public async Task DeleteCohort_InvalidId_ReturnsNotFound()
        {
            // Act
            var result = await _controller.DeleteCohort(1);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
