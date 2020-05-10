using Xunit;

namespace TMenos3.NetCore.EFTesting.Tests
{
    public class PlayersRepositoryTests
    {
        [Fact]
        public void AddAsync_TeamExistsAndPlayerIsValid_PlayerIsAdded()
        {
            // Arrange
            // 1- Create AppDbContext instance
            // 2- Add a team
            // 3- Create PlayerRepository instance
            // 4- Create player to add

            // Act
            // 4- Call repository.AddAsync(player)

            // Assert
            // 5- Verify context.Players.Any(player => 
            //        player.TeamId == teamId &&
            //        player.Id == playerAddedId)
        }

        [Fact]
        public void AddAsync_TeamDoesNotExistAndPlayerIsValid_TeamNotFoundExceptionIsThrown()
        {
            // Arrange
            // 1- Create AppDbContext instance
            // 3- Create PlayerRepository instance
            // 4- Create player to add

            // Act
            // 4- Call repository.AddAsync(player)

            // Assert
            // 5- Verify TeamNotFoundException is thrown
        }
    }
}
