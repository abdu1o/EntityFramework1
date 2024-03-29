using Microsoft.EntityFrameworkCore;
using SpainChampionship.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpainChampionship.Data
{
    public class ChampionshipContext : DbContext
    {
        public ChampionshipContext(DbContextOptions<ChampionshipContext> options)
            : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }
    }
}

