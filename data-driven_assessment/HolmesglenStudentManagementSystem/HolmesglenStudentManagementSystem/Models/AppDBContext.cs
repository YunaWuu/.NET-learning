using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HolmesglenStudentManagementSystem.DataAccessLayer;
using Microsoft.EntityFrameworkCore;


namespace HolmesglenStudentManagementSystem.Models
{
    public class AppDBContext : DbContext 
    {    
        public DbSet<SubjectRecord> Subject { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(HolmesglenDB.ConnectionString);
        }
    }
}
