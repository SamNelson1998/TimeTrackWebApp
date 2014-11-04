using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TimeTracker.Models
{
    public class HomeModels
    {
        public int UserID {get; set;}
        public String Name { get; set; }
        public String Roll { get; set; }
        public int ID { get; set; }
        public int IssueID { get; set; }
        public String Description { get; set; }
        public DateTime Date { get; set; }
    }
    public class TimeDBContext : DbContext {
        public DbSet<HomeModels> TimeTrack { get; set; }
    }
}