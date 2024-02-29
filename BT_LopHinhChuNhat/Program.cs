using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LopHinhChuNhat
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the width: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height: ");
            double height = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width, height);

            Console.WriteLine("Your Rectangle \n" + rectangle.Display());
            Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
            Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());

            Console.ReadKey();
        }
    }
}

