using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace TimeTracker.Models
{
    [Table("TimeModels")]
    public class TimeModels
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public DateTime Date { get; set; }
        public float Hours { get; set; }
        public string Description { get; set; }
        public int IssueID { get; set; }
    }
    public class TimeModelsContext : DbContext
    {
        public DbSet<TimeModels> Time { get; set; }
    }
}