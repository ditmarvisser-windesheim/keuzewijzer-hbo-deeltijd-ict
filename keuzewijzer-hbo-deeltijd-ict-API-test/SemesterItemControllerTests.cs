using keuzewijzer_hbo_deeltijd_ict_API.Controllers;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;
using keuzewijzer_hbo_deeltijd_ict_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Keuzewijzer_hbo_deeltijd_ict_API.Tests.Controllers
{
    public class SemesterItemControllerTests : IDisposable
    {
        private SemesterItemController _controller;
        private DbContextOptions<KeuzewijzerContext> _options;

        public SemesterItemControllerTests()
        {
            _options = new DbContextOptionsBuilder<KeuzewijzerContext>()
                .UseInMemoryDatabase(databaseName: "test_database")
                .Options;

            _controller = new SemesterItemController(new KeuzewijzerContext(_options));
        }

        public void Dispose()
        {
            using (var context = new KeuzewijzerContext(_options))
            {
                var semesterItem = context.SemesterItems.FirstOrDefault(item => item.Id == 1);
                if (semesterItem != null)
                {
                    context.SemesterItems.Remove(semesterItem);
                    context.SaveChanges();
                }
            }
        }
          [Fact]
            public async Task GetSemesterItemsByCohort_ValidCohortYear_ReturnsSemesterItems()
            {
                // Arrange
                using (var context = new KeuzewijzerContext(_options))
                {
                    // Add test data to the in-memory database
                    var cohort = new Cohort
                    {
                        Year = 2022,
                        Name = "Sample Cohort"
                    };
                    var semesterItem1 = new SemesterItem
                    {
                        Id = 1,
                        Description = "Sample Description 1",
                        Name = "Sample Name 1",
                        Cohorts = new List<Cohort> { cohort }
                    };
                    var semesterItem2 = new SemesterItem
                    {
                        Id = 2,
                        Description = "Sample Description 2",
                        Name = "Sample Name 2",
                        Cohorts = new List<Cohort> { cohort }
                    };
                    context.Cohorts.Add(cohort);
                    context.SemesterItems.AddRange(semesterItem1, semesterItem2);
                    context.SaveChanges();
                }

                // Act
                var result = await _controller.GetSemesterItemsByCohort(2022);

                // Assert
                Assert.NotNull(result);
                var actionResult = Assert.IsType<ActionResult<IEnumerable<SemesterItem>>>(result);
                var semesterItems = Assert.IsType<List<SemesterItem>>(actionResult.Value);

                Assert.Equal(2, semesterItems.Count);
                Assert.Equal("Sample Description 1", semesterItems[0].Description);
                Assert.Equal("Sample Name 1", semesterItems[0].Name);
                Assert.Equal("Sample Description 2", semesterItems[1].Description);
                Assert.Equal("Sample Name 2", semesterItems[1].Name);
            }

        [Fact]
        public async Task GetSemesterItemsByCohort_CohortYearNotFound_ReturnsNotFound()
        {
            // Arrange
            using (var context = new KeuzewijzerContext(_options))
            {
                // Add test data to the in-memory database (excluding the desired cohort year)
                var cohort = new Cohort
                {
                    Year = 2021,
                    Name = "Sample Cohort"
                };
                var semesterItem = new SemesterItem
                {
                    Id = 1,
                    Description = "Sample Description",
                    Name = "Sample Name",
                    Cohorts = new List<Cohort> { cohort }
                };
                context.Cohorts.Add(cohort);
                context.SemesterItems.Add(semesterItem);
                context.SaveChanges();
            }

            // Act
            var result = await _controller.GetSemesterItemsByCohort(2020); // Cohort year that doesn't exist in the test data

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }


        [Fact]
        public async Task GetSemesterItem_ValidId_ReturnsSemesterItem()
        {
            // Arrange
            using (var context = new KeuzewijzerContext(_options))
            {
                // Add test data to the in-memory database
                var semesterItem = new SemesterItem
                {
                    Id = 1,
                    Description = "Sample Description",
                    Name = "Sample Name"
                };
                context.SemesterItems.Add(semesterItem);
                context.SaveChanges();
            }

            // Act
            var result = await _controller.GetSemesterItems(1);

            // Assert
            Assert.NotNull(result);
            var actionResult = Assert.IsType<ActionResult<SemesterItem>>(result);
            var returnedItem = Assert.IsType<SemesterItem>(actionResult.Value);

            Assert.Equal(1, returnedItem.Id);
            Assert.Equal("Sample Description", returnedItem.Description);
            Assert.Equal("Sample Name", returnedItem.Name);
        }



        [Fact]
        public async Task GetSemesterItem_InvalidId_ReturnsNotFound()
        {
            // Act
            var result = await _controller.GetSemesterItems(1);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public async Task CreateSemesterItem_ValidItem_ReturnsCreatedItem()
        {
            // Arrange
            var semesterItem = new SemesterItem
            {
                Id = 1,
                Description = "Sample Description",
                Name = "Sample Name"
            };

            // Act
            var result = await _controller.PostSemesterItem(semesterItem);

            // Assert
            Assert.IsType<ActionResult<SemesterItem>>(result);

            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result.Result);
            Assert.Equal("GetSemesterItems", createdAtActionResult.ActionName);
            Assert.Equal(semesterItem, createdAtActionResult.Value);

            using (var context = new KeuzewijzerContext(_options))
            {
                var createdItem = await context.SemesterItems.FindAsync(1);
                Assert.NotNull(createdItem);
                Assert.Equal(1, createdItem.Id);
            }
        }


        [Fact]
        public async Task UpdateSemesterItem_ValidItem_ReturnsNoContent()
        {
            // Arrange
            using (var context = new KeuzewijzerContext(_options))
            {
                // Add test data to the in-memory database
                var semesterItem = new SemesterItem
                {
                    Id = 1,
                    Description = "Sample Description",
                    Name = "Sample Name"
                };
                context.SemesterItems.Add(semesterItem);
                context.SaveChanges();
            }

            var updatedItem = new SemesterItem { Id = 1 };

            // Act
            var result = await _controller.PutSemesterItem(1, updatedItem);

            // Assert
            Assert.IsType<CreatedAtActionResult>(result);

            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
            Assert.Equal("GetSemesterItems", createdAtActionResult.ActionName);
            Assert.Equal(updatedItem, createdAtActionResult.Value);


            using (var context = new KeuzewijzerContext(_options))
            {
                var existingItem = await context.SemesterItems.FindAsync(1);
                Assert.NotNull(existingItem);
                Assert.Equal(updatedItem.Id, existingItem.Id);
            }
        }


        [Fact]
        public async Task UpdateSemesterItem_InvalidId_ReturnsNotFound()
        {
            // Arrange
            var updatedItem = new SemesterItem
            {
                Id = 1,
                Description = "Sample Description",
                Name = "Sample Name"
            };
            // Act
            var result = await _controller.PutSemesterItem(1, updatedItem);

            // Assert
            Assert.IsType<NotFoundResult>(result);

            using (var context = new KeuzewijzerContext(_options))
            {
                var existingItem = await context.SemesterItems.FindAsync(1);
                Assert.Null(existingItem);
            }
        }

        [Fact]
        public async Task DeleteSemesterItem_ValidId_ReturnsNoContent()
        {
            // Arrange
            using (var context = new KeuzewijzerContext(_options))
            {
                // Add test data to the in-memory database
                // Arrange
                var semesterItem = new SemesterItem
                {
                    Id = 1,
                    Description = "Sample Description",
                    Name = "Sample Name"
                };
                context.SemesterItems.Add(semesterItem);
                context.SaveChanges();
            }

            // Act
            var result = await _controller.DeleteModule(1);

            // Assert
            Assert.IsType<NoContentResult>(result);

            using (var context = new KeuzewijzerContext(_options))
            {
                var existingItem = await context.SemesterItems.FindAsync(1);
                Assert.Null(existingItem);
            }
        }

        [Fact]
        public async Task DeleteSemesterItem_InvalidId_ReturnsNotFound()
        {
            // Act
            var result = await _controller.DeleteModule(1);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
