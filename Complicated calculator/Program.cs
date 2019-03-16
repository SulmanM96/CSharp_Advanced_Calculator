using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complicated_calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what type of calculation do you want?");
            Console.WriteLine("1.Mathematical");
            Console.WriteLine("2.Area of shape");
            Console.Write("Enter Choice(1-2):");

            int options = int.Parse(Console.ReadLine());
            switch (options)
            {
                case 1:
                    double num1, num2, ans;
                    string ops;

                    Console.Write("Enter the first number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter your second number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your operation ( * , / , +, -) ");
                    ops = Console.ReadLine();

                    double Add(double val1, double val2)
                    {
                        return val1 + val2;
                    }
                    double Multiplication(double val1, double val2)
                    {
                        return val1 * val2;
                    }
                    double Divide(double val1, double val2)
                    {
                        return val1 / val2;
                    }
                    double Subtract(double val1, double val2)
                    {
                        return val1 - val2;
                    }

                    if (ops == "-") { ans = Subtract(num1, num2);
                        Console.WriteLine(ans); }
                    else if (ops == "/") { ans = Divide(num1, num2);
                        Console.WriteLine(ans); }
                    else if (ops == "*") { ans = Multiplication(num1, num2);
                        Console.WriteLine(ans); }
                    else if (ops == "+") { ans = Add(num1, num2);
                        Console.WriteLine(ans); }

                    else
                    {
                        Console.WriteLine("incorrect format! try again!");
                        Console.ReadLine();
                    }
                    Console.ReadLine();
                     
                    break;
            
                    
                case 2:
                    {            
                        
                        string shape;
                        double area, x1, x2;

                        Console.Write("Enter your shape ( c , s , r) ");
                        shape = Console.ReadLine();

                        Console.Write("Enter the first number: ");
                        x1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter your second number: ");
                        x2 = Convert.ToInt32(Console.ReadLine());

                        double Circle(double val1, double val2)
                        {
                            return area = Math.PI * val1 * val2;
                            
                        }
                        double Rectangle(double val1, double val2)
                        {
                            return area = val1 * val2; ;
                        }
                        double Square(double val1, double val2)
                        {
                            return area = val1 * val2;
                            
                        }

                        if (shape == "c") { ans = Circle(x1, x2);
                            Console.WriteLine(ans); }
                        else if (shape == "r") { ans = Rectangle(x1, x2);
                            Console.WriteLine(ans); }
                        else if (shape == "s") { ans = Square(x1, x2);
                            Console.WriteLine(ans); }

                        break;

                        }
                    }
            }
        }
    }

