using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorBasedDrawing
{
    class Rectangle
    {
        public void Main()
        {
            Console.WriteLine("Enter the x co-ordinate :");
            int xCoordinate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the y co-ordinate :");
            int yCoordinate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Length of the Rectangle :");
            int Length = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of the Rectangle :");
            int Breadth = Convert.ToInt16(Console.ReadLine());

            Show display = new Show();
            display.Rectangle(xCoordinate, yCoordinate, Length, Breadth);
        }
    }
}

    
