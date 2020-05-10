using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMenos3.NetCore.EFTesting.Database.Models;

namespace TMenos3.NetCore.EFTesting.Database.Repositories
{
    public interface ITeamsRepository
    {
        Task<IEnumerable<Team>> GetAllAsync();

        Task<Team> GetAsync(Guid id);

        Task<Guid> AddAsync(Team team);

        Task DeleteAsync(Guid id);
    }
}
