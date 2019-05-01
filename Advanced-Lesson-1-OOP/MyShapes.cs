using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public class MyShapes : BaseShapes
    {
        public class MyCircle : Circle, IShape
        {
            private int myrad;
            public int Rad
            {
                get { return myrad; }
                set { myrad = Rad; }
            }
            public MyCircle(int Rad)
            {
                myrad = Rad;
                MySCircle(myrad);
            }

            public double MySCircle(int myrad)
            {
                double NSCir = Math.PI * Math.Pow(myrad, 2);
                return Math.Round(NSCir, 4);
            }
            public new void Draw()
            {
                Console.Write("Circle R {0} ", MySCircle(myrad));
            }
        }

        public class MyTriangle : Triangle, IShape
        {
            public int A { get; set; }
            public int B { get; set; }
            private int S;

            public MyTriangle()
            {
                MySTriangle(A, B);
            }

            public double MySTriangle(int A, int B)
            {
                S = A * B / 2;
                return S;
            }

            public new void Draw()
            {
                Console.Write("Triangle {0} ", MySTriangle(A, B));
            }
        }

        public class MyFoursquare : Foursquare, IShape
        {
            public int a { get; set; }

            public MyFoursquare()
            {
                this.a = Convert.ToInt32(Math.Pow(a, 2));
            }

            public void Draw()
            {
                Console.WriteLine("Foursquare {0} ", a);
            }
        }
    }
}
