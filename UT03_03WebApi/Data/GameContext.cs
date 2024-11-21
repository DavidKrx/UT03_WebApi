using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UT03_03WebApi.Models;

    public class GameContext : DbContext
    {
        public GameContext (DbContextOptions<GameContext> options)
            : base(options)
        {
}

public DbSet<UT03_03WebApi.Models.Game> Game { get; set; }

public DbSet<UT03_03WebApi.Models.Genre> Genre { get; set; }
    }
