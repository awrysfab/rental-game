using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using game_rental.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace game_rental.DAL
{
    public class GameRentalContext: DbContext
    {
        public GameRentalContext() : base("GameRentalContext")
        {
        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Renter> Renters { get; set; }
        public DbSet<Rent> Rents { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}