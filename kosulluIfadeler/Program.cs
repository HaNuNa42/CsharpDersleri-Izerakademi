using System;

namespace kosulluIfadeler
{
    class Program
    {


        static void Q1()
        {
            Console.Write("enter number 1: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter number 2: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter number 3: ");
            double number3 = Convert.ToDouble(Console.ReadLine());
            double average = (number1 + number2 + number3) / 3;
            Console.Write("average : " + average);

            if(average >= 65)
            { 
                Console.WriteLine(" passed");
            }
            else
            {
                Console.WriteLine(" failed");
            }
        }

        static void Q2() 
        {
            Console.Write("enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
        }

        static void Q3()
        {
            Console.Write("enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("correct number");
            }
            else
            {
                Console.WriteLine("wrong number");
            }
        }





        static void Main(string[] args)
        {

            /*

            Console.WriteLine("ConditionalStatements - koşullu ifadeler");

            int number = 10;

            if (number == 0)
            {
                Console.WriteLine("number is equal to zero");
            }
            
            if (number > 0)
            {
                Console.WriteLine("number is positive");
            }

            if (number < 0)
            {
                Console.WriteLine("number is negative");
            }

            Console.WriteLine("*********************");
            
            //olması gereken diğer kullanımı; yukarıdaki de olur fakat aşağıdaki gibi performans elde etmez.

            if (number == 0)
            {
                Console.WriteLine("number is equal to zero");
            }

            else if (number > 0)
            {
                Console.WriteLine("number is positive");
            }

            else
            {
                Console.WriteLine("number is negative");
            }


            //switch case kullanımı

            int day = 5;
            switch (day) 
            {
                case 1:
                    Console.WriteLine("pazartesi"); break;
                case 2:
                    Console.WriteLine("salı"); break;
                case 3:
                    Console.WriteLine("çarşamba"); break;
                case 4:
                    Console.WriteLine("perşembe"); break;
                case 5:
                    Console.WriteLine("cuma"); break;
                case 6:
                    Console.WriteLine("cumartesi"); break;
                case 7:
                    Console.WriteLine("pazar"); break;
                default:
                    Console.WriteLine("invalid input value"); break;
            }

            Console.WriteLine("ternary operator"); 
            number = 10;
            //variable = (condition) ? expressionTrue : expressionFalse
            string result = (number > 0) ? "number is positive" : "number is negative";
            Console.WriteLine(result);

            */

            //Q1();
            //Q2();
            Q3();

        }
    }
}
