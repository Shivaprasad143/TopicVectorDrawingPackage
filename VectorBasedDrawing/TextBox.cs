using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorBasedDrawing
{
    class TextBox
    {
        public void Main()
        {
            Console.WriteLine("Enter the x co-ordinate :");
            int xCoordinate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the y co-ordinate :");
            int yCoordinate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the text:");
            string text = "";
            Show display = new Show();
            display.Textbox(xCoordinate, yCoordinate, text);
        }
    }
}
