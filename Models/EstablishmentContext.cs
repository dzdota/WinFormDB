using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SimpleDBProject.Models
{
    class EstablishmentContext : DbContext
    {

        public EstablishmentContext() : base("Establishment")
        {
        }
        public DbSet<Establishment> Establishments { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Countrie> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<City> Cityes { get; set; }
    }
}