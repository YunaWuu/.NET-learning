using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample.Models
{
    public class AppDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            // change the connection string below as needed
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\yanan\source\repos\.NET-learning\DisconnectedMode\Tutorial_Accessing_Database_Using_C#_2of3_Disconnected_Mode\Database_File\HolmesglenInstitute.db");
        }
    }
}
