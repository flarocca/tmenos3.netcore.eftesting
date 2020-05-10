using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMenos3.NetCore.EFTesting.Database.Models
{
    public class Player
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public PositionType Position { get; set; }

        public Guid TeamId { get; set; }

        public Team Team { get; set; }
    }
}
