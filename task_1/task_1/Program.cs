using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*bool flag = true;
            int num = 0;
            do
            {
                try
                {
                    Console.WriteLine("Enter number");
                    num = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your number is " + generate(num));
                    flag = false;
                }
                catch(FormatException fe)
                {
                    Console.WriteLine("Wrong input " + num);
                }
                catch(ArithmeticException ae)
                {
                    Console.WriteLine("Wrong input " + ae.Message);
                }

            } while(flag);*/
            //Console.WriteLine("Good!!!");


            /* int first;
             int second;
             int a = 0;
             try
             {
                 Console.Write("Enter the first number ");
                 first = int.Parse(Console.ReadLine());
                 Console.Write("\nEnter the second number ");
                 second = int.Parse(Console.ReadLine());
                 Console.WriteLine("You result is: " + (first / second));

             }
             catch(DivideByZeroException)
             {
                 Console.WriteLine("Your result is wrong");
             }*/

            byte[] array = generatecount();
            fillArray(array);
            printArray(array);


            
            

            Console.ReadLine();
        }

        static byte[] generatecount()
        {
            byte[] result;
            Random rand = new Random();
            result = new byte[rand.Next(1, 10)];
            return result;
        }

        static void fillArray(byte[] array)
        {
            Random rand = new Random();
            
            for (int i = 0; i < array.Length; i++)
            {
                int index = rand.Next(0, 15);
                int value = rand.Next(-400, 400);
                try
                {
                    array[index] = (byte)value;
                }
                catch(IndexOutOfRangeException ie)
                {

                }
                catch(ArgumentOutOfRangeException ie)
                {

                }
            }
        }

        static void printArray(byte[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static int generate(int num)
        {
            int result;
            if (num < 0 || num > 255)
            {
                throw new ArithmeticException();
            }
            else
            {
                Random rand = new Random();
                result = rand.Next(num);
            }
            return result;
        }
    }
}
