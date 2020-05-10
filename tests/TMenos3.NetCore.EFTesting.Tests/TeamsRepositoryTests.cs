using Xunit;

namespace TMenos3.NetCore.EFTesting.Tests
{
    public class TeamsRepositoryTests
    {
        [Fact]
        public void AddAsync_ValidTeam_TeamIsAdded()
        {
            // Arrange
            // 1- Create AppDbContext instance
            // 2- Create TeamsRepository instance
            // 3- Create valid team

            // Act
            // 4- Call repository.AddAsync(team)

            // Assert
            // 5- Verify context.Teams.Any(team => team.Id == teamAddedId)
        }

        [Fact]
        public void GetAsync_TeamWithIdExists_TeamIsRetrieved()
        {
            // Arrange
            // 1- Create AppDbContext instance
            // 2- Create multiple teams
            // 3- Create team to retrieve
            // 4- Create TeamsRepository instance

            // Act
            // 5- Call repository.GetAsync(teamToRetrieveId)

            // Assert
            // 5- Verify teamRetrieved is the expected
        }
    }
}
