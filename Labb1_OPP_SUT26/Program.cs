using Labb1_OPP_SUT26.Models;

namespace Labb1_OOP_SUT26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle Circle1 = new Circle(5);
            Console.WriteLine(Circle1.Radius);
            Console.WriteLine(Circle1.GetArea());

            Circle Circle2 = new Circle(6);
            Console.WriteLine(Circle2.Radius);
            Console.WriteLine(Circle2.GetArea());

            Triangle Traingle1 = new Triangle(5,3);
            Console.WriteLine(Traingle1.GetArea());
        }
    }
}
