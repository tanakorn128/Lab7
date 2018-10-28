using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ทดลองเรื่องการใช้งานคลาสและวัตถุ__object_
{
    class Program
    {
        static void Main(string[] args)
        {
            Point mypoint = new Point();
            mypoint.X = 10;
            mypoint.Y = 20;
            Console.WriteLine("my point.x {0}",mypoint.X);
            Console.WriteLine("my point.x {0}",mypoint.Y);
            Console.ReadKey();
        }
        class Point
        {
            private int x;
            private int y;
            public int X
            {
                get { return x; }
                set { x = value; }
            }
            public int Y
            {
                get { return y; }
                set { y = value; }
            }
        }
    }
}
