namespace ConsoleApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleApp.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ConsoleApp.MyDbContext";
        }

        protected override void Seed(ConsoleApp.MyDbContext context)
        {
            //context.Students.Add(new Student { Name = "Student1-Name", RollNumber = 101, Address = "Student1-Address" });
            //context.Students.Add(new Student { Name = "Student2-Name", RollNumber = 102, Address = "Student2-Address" });
            //context.Students.Add(new Student { Name = "Student3-Name", RollNumber = 103, Address = "Student3-Address" });
            //context.Students.Add(new Student { Name = "Student4-Name", RollNumber = 104, Address = "Student4-Address" });
            //context.Students.Add(new Student { Name = "Student5-Name", RollNumber = 105, Address = "Student5-Address" });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
