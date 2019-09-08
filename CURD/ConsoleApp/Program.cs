using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataEntry();
            //Student student = new Student() { RollNumber = 1, Name = "Student 1 Name", Address = "Student 1 Addres" };
            //Student student2 = new Student() { RollNumber = 1, Name = "Student 2 Name", Address = "Student 1 Addres" };
            //AddStudent(student);
            //UpdateStudent(student2);
            //DeleteStudent(1);

            Console.WriteLine("Task Complete");
        }
        private static void DataEntry()
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                myDbContext.Students.Add(new Student { Name = "Student1-Name", RollNumber = 101, Address = "Student1-Address" });
                myDbContext.Students.Add(new Student { Name = "Student2-Name", RollNumber = 102, Address = "Student2-Address" });
                myDbContext.Students.Add(new Student { Name = "Student3-Name", RollNumber = 103, Address = "Student3-Address" });
                myDbContext.Students.Add(new Student { Name = "Student4-Name", RollNumber = 104, Address = "Student4-Address" });
                myDbContext.Students.Add(new Student { Name = "Student5-Name", RollNumber = 105, Address = "Student5-Address" });
                myDbContext.SaveChanges();
            }
        }
        private static void AddStudent(Student student)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                var find = myDbContext.Students.Find(student.RollNumber);
                if (find == null)
                {
                    myDbContext.Students.Add(student);
                    myDbContext.SaveChanges();
                }

            }
        }
        private static void UpdateStudent(Student student)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                Student find = (from a in myDbContext.Students where a.RollNumber == student.RollNumber select a).FirstOrDefault();
                if (find !=null)
                {
                    find.Name = student.Name;
                    find.Address = student.Address;
                    myDbContext.SaveChanges();
                }
                
            }

        }
        private static void DeleteStudent(int RollNumber)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                Student find = (from a in myDbContext.Students where a.RollNumber == RollNumber select a).FirstOrDefault();

                if (find != null)
                {
                    myDbContext.Students.Remove(find);
                    myDbContext.SaveChanges();
                }

            }

        }
    }
}
