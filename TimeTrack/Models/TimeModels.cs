using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TimeTrack.Models
{
    public class TimeModels
    {
        public string User { get; set; }
        public int ID { get; set; }
        public int Mon { get; set; }
        public int Tue { get; set; }
        public int Wed { get; set; }
        public int Thu { get; set; }
        public int Fri { get; set; }
        public int Sat { get; set; }
        public int Sun { get; set; }

    }
    public class TimeDBContext : DbContext
    {
        public DbSet<TimeModels> TimeModels { get; set; }
    }
}