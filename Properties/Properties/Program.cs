using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public class Student
        {
            private string name;
            private string id;
            private float gpa;

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
