using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorBasedDrawing
{
    class Ellipse
    {
        public void Main()
        {
            Console.WriteLine("Enter the x co-ordinate :");
            int xCoordinate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the y co-ordinate :");
            int yCoordinate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Length of the Ellipse:");
            int length = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the height of the Ellipse:");
            int height = Convert.ToInt16(Console.ReadLine());
            Show display = new Show();
            display.Ellipse(xCoordinate, yCoordinate, length, height);
        }
    }
}
