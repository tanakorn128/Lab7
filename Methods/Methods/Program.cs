using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Thanakorn", "60030041");
            

            Console.WriteLine("Student name = " + s1.Name + ", ID = " + s1.Id );
            Console.ReadLine();
        }
        public class Student
        {
            private string name;
            private string id;
            private float gpa;

            public Student(string value1, string value2)
            {
                this.name = value1;
                this.id = value2;
                
            }

            public string Name
            {
                get { return name; }
            }
            public string Id
            {
                get { return id; }
            }
            public float Gpa
            {
                get { return gpa; }
                set { gpa = value; }
            }

        }
        

    }
}