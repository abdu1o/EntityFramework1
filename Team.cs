using System.ComponentModel.DataAnnotations;

namespace SpainChampionship.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public int Draws { get; set; }
    }
}
