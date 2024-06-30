using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ans;
            int height;
            int width;
            float res;
            float radius;
            Console.WriteLine("Please, Enter a key if it is Rectangle r and if it is a Circle c.");
            ans = Console.ReadLine();
            if (ans == "r")
            {
                Console.WriteLine("Please Enter width.");
                width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter height.");
                height = Convert.ToInt32(Console.ReadLine());
                res =height*width;
                Console.WriteLine("The result is " + res);





            }
            else
            {
                Console.WriteLine("Please,Enter a radius.");
                radius=float.Parse(Console.ReadLine());
                res = (float)Math.PI * (radius * radius);
                Console.WriteLine("The result is "+res);




            }
            Console.ReadLine();
        }
    }
}
