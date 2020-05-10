using System;
using System.Collections.Generic;

namespace TMenos3.NetCore.EFTesting.API.Dtos
{
    public class TeamDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int FoundedYear { get; set; }

        public ICollection<PlayerDto> Players { get; set; }
    }
}
