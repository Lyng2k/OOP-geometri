using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(5);
            
            Console.WriteLine(square1.circumference());
            Square square2 = new Square();
            square2.Side = 4;
            Console.WriteLine(square2.circumference());

            Square square3 = new Square();
            square3.Side = 5;
            Console.WriteLine(square3.area());

            Console.ReadKey();
        }
    }
}
