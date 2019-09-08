using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class MyDbContext:DbContext
    {
        public MyDbContext():base("ConStr")
        {

        }
        public DbSet<Student> Students { get; set; } 


    }
}
