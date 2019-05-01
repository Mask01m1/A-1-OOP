using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
   public class BaseShapes
   {
        public class Circle : IShape
        {
            private int rad;

            public Circle()
            {
                SCircle(rad);
            }
            public double SCircle(int rad)
            {
                double SCir = Math.PI * Math.Pow(rad, 2);
                return Math.Round(SCir, 4);
            }

            public void Draw()
            {
                //Console.Write("Circle R {0} ", SCircle(rad));
            }
        }


        public class Triangle : IShape
        {
            private int a;
            private int b;
            private int S;

            public Triangle()
            {
                this.a = a;
                this.b = b;
                this.S = a * b / 2;
            }

            public void Draw()
            {
                Console.Write("Triangle {0} ", S);
            }
        }

        public class Foursquare : IShape
        {
            private int a;

            public Foursquare()
            {
                this.a = Convert.ToInt32(Math.Pow(a, 2));
            }

            public void Draw()
            {
                Console.WriteLine("Foursquare {0} ", a);
            }
        }

        public interface IShape
        {
            void Draw();
        }
   }
}
