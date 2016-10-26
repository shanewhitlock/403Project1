using SWProject1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SWProject1.DAL
{
    public class MissionContext : DbContext
    {
        public MissionContext()
            : base("MissionContext")
        {

        }

        public DbSet<Mission> Missions { get; set; }
        public DbSet<President> Presidents { get; set; }
        public DbSet<Country> Countrys { get; set; }
        public DbSet<NewMission> NewMissions { get; set; }
    }
}