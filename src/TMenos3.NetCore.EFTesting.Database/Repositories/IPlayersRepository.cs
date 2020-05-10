using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMenos3.NetCore.EFTesting.Database.Models;

namespace TMenos3.NetCore.EFTesting.Database.Repositories
{
    public interface IPlayersRepository
    {
        Task<IEnumerable<Player>> GetAllAsync(Guid teamId);

        Task<Player> GetAsync(Guid teamId, Guid id);

        Task<Guid> AddAsync(Player team);

        Task DeleteAsync(Guid teamId, Guid id);
    }
}
