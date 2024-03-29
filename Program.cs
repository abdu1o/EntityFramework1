using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SpainChampionship.Data;
using SpainChampionship.Models;

namespace EntityFramework.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<ChampionshipContext>(options => options.UseSqlServer("Data Source=DESKTOP-GA6HPG7;Initial Catalog=SpainTournament;Integrated Security=True;Encrypt=False;")).BuildServiceProvider();

            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ChampionshipContext>();
                SetDb.Initialize(context);
            }

            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ChampionshipContext>();

                //SetDb.ClearTable(context); //not necessary

                foreach (var team in context.Teams)
                {
                    Console.WriteLine($"Name: {team.Name} \nCity: {team.City} \nWins: {team.Wins} \nLosses: {team.Losses} \nDraws: {team.Draws}\n\n");
                }
            }
        }
    }
}
