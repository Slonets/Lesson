using DateAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAccess.Data
{
    public static class Seed
    {        
        public static void SeedStudents(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new[] 
                {
                new Student(){Id=1, FirstName="Boris", LastName="Petrovich", Age=17},
                new Student(){Id=2,FirstName="Bohdan", LastName="Slonets", Age=30},
                new Student(){Id=3,FirstName="Max", LastName="Prymak", Age=21}
                }
                );
        }
    }
}
