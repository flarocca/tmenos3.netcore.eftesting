using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using TMenos3.NetCore.EFTesting.Database;
using TMenos3.NetCore.EFTesting.Database.Models;
using TMenos3.NetCore.EFTesting.Database.Repositories;
using Xunit;

namespace TMenos3.NetCore.EFTesting.Tests
{
    public class TeamsRepositoryTests
    {
        private const string CONNECTION_STRING =
            "Data Source=.;Initial Catalog=TestApp;Trusted_Connection=True;";

        [Fact]
        public async Task AddAsync_ValidTeam_TeamIsAdded()
        {
            // Arrange
            var options = new DbContextOptionsBuilder()
                .UseSqlServer(CONNECTION_STRING)
                .Options;

            var teamToAdd = new Team
            {
                Name = "Test team",
                FoundedYear = 2020
            };
            Guid teamAddedId;

            using (var context = new AppDbContext(options))
            {
                await context.Database.EnsureCreatedAsync();

                var repository = new TeamsRepository(context);

                // Act
                teamAddedId = await repository.AddAsync(teamToAdd);
            }

            using (var context = new AppDbContext(options))
            {
                // Assert
                var result = await context.Teams
                    .AnyAsync(team => team.Id == teamAddedId);

                Assert.True(result);
            }
        }

        [Fact]
        public async Task GetAsync_TeamWithIdExists_TeamIsRetrieved()
        {
            // Arrange
            var options = new DbContextOptionsBuilder()
                .UseSqlServer(CONNECTION_STRING)
                .Options;

            var team = new Team
            {
                Name = "Test team",
                FoundedYear = 2020
            };

            using (var context = new AppDbContext(options))
            {
                await context.Database.EnsureCreatedAsync();

                context.Teams.Add(team);
                await context.SaveChangesAsync();
            }

            using (var context = new AppDbContext(options))
            {
                // Act
                var result = await context.Teams
                    .FirstOrDefaultAsync(t => t.Id == team.Id);

                // Assert
                Assert.NotNull(result);
                Assert.Equal(team.Name, result.Name);
            }
        }
    }
}
