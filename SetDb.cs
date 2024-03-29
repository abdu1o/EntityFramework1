using SpainChampionship.Data;

namespace SpainChampionship.Models
{
    public static class SetDb
    {
        public static void Initialize(ChampionshipContext context) // Оновлений метод Initialize
        {
            context.Teams.AddRange(
                new Team
                {
                    Name = "Real Madrid",
                    City = "Madrid",
                    Wins = 20,
                    Losses = 1256,
                    Draws = 3
                },
                new Team
                {
                    Name = "FC Barcelona",
                    City = "Barcelona",
                    Wins = 18,
                    Losses = 1325,
                    Draws = 3
                },
                new Team
                {
                    Name = "Chernomorets",
                    City = "Odesa",
                    Wins = 2002,
                    Losses = 0,
                    Draws = 0
                }
            );

            context.SaveChanges();
        }

        public static void ClearTable(ChampionshipContext context)
        {
            var allTeams = context.Teams.ToList();
            context.Teams.RemoveRange(allTeams);
            context.SaveChanges();
        }
    }
}
