using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorBasedDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Do you want to add a widget?(Y/N) :- ");
            char select = Convert.ToChar(Console.ReadLine());
            do
            {
                Console.Clear();
                if (select == 'Y' || select == 'y')
                {
                    Console.WriteLine("Which widget do you want to add?");
                    Console.WriteLine("1.Rectangle ");
                    Console.WriteLine("2.Square ");
                    Console.WriteLine("3. Circle ");
                    Console.WriteLine("4.Textbox ");
                    Console.WriteLine("5.Exit");
                    Console.WriteLine("");
                    char Selection = Convert.ToChar(Console.ReadLine());
                    if (Selection == '1')
                    {
                        Rectangle recobj = new VectorBasedDrawing.Rectangle();
                        recobj.Main();
                    }
                    else if (Selection == '2')
                    {
                        Square sqobj = new VectorBasedDrawing.Square();
                        sqobj.Main();
                    }
                    else if (Selection == '3')
                    {
                        Circle cirobj = new VectorBasedDrawing.Circle();
                        cirobj.Main();
                    }
                    else if (Selection == '4')
                    {
                        TextBox textobj = new TextBox();
                        textobj.Main();
                    }
                    else if (Selection == '5')
                    {
                        select = 'N';
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Entry! Try Again?");
                        Console.WriteLine("Do you want to add a widget?(Y/N) :-");
                        select = Convert.ToChar(Console.ReadLine());
                        continue;
                    }
                    Console.Write("Do you want to add another widget?(Y/N) :- ");
                    select = Convert.ToChar(Console.ReadLine());
                    continue;
                }
                else if (select == 'N' || select == 'n')
                {
                    Console.WriteLine("Alright!");
                    select = 'N';
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong entry! Please enter again!");
                    Console.Write("Do you want to add another widget?(Y/N) :- ");
                    select = Convert.ToChar(Console.ReadLine());
                    continue;
                }
            }
            while (select == 'Y' || select == 'y');

            if (select == 'n' || select == 'N')
            {
                Console.WriteLine("Alright;");
            }
            Console.ReadLine();
        }
    }
}

