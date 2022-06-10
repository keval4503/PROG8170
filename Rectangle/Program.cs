using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle _rectangleObj = new Rectangle();
            int length = -1, width = -1, temp;
            Console.WriteLine("Assignment 02");
            while (length < 0)
            {
                Console.WriteLine("Enter the length:");
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    if (temp > 0)
                        length = temp;
                }
            }
            while (width < 0)
            {
                Console.WriteLine("Enter the width:");
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    if (temp > 0)
                        width = temp;
                }
            }

            _rectangleObj = new Rectangle(width, length);
            int selectedOption = 0;
            Console.Clear();
            while (selectedOption != 7)
            {
                Console.Clear();
                Console.WriteLine("1.Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3.Get Rectangle Width");
                Console.WriteLine("4.Change Rectangle width");
                Console.WriteLine("5.Get Rectangle Perimeter");
                Console.WriteLine("6.Get Rectangle Area");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Choose any option");

                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    if (temp == 7)
                        return;
                    selectedOption = temp;
                    int tempo;
                    switch (selectedOption)
                    {
                        case 1:
                            Console.WriteLine("Length: " + _rectangleObj.GetLength().ToString());
                            break;
                        case 2:
                            length = -1;
                            while (length < 0)
                            {
                                Console.WriteLine("Enter new length");
                                if (int.TryParse(Console.ReadLine(), out tempo))
                                {
                                    if (tempo > 0)
                                        length = tempo;
                                }
                            }
                            _rectangleObj.SetLength(length);
                            break;
                        case 3:
                            Console.WriteLine("width: " + _rectangleObj.GetWidth().ToString());
                            break;
                        case 4:
                            width = -1;
                            while (width < 0)
                            {
                                Console.WriteLine("please Enter a new length");
                                if (int.TryParse(Console.ReadLine(), out tempo))
                                {
                                    if (tempo > 0)
                                        width = tempo;
                                }
                            }
                            _rectangleObj.SetWidth(width);
                            break;
                        case 5:
                            Console.WriteLine("Perimeter: " + _rectangleObj.CalculatePerimeter().ToString());
                            break;
                        case 6:
                            Console.WriteLine("Area: " + _rectangleObj.CalculateArea().ToString());
                            break;

                    }
                    Console.WriteLine("Press any Key to Continue");
                    Console.ReadLine();
                }

            }
        }
    }
}
