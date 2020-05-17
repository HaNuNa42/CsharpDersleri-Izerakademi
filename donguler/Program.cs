using System;
using System.Transactions;

namespace donguler
{
    class Program
    {



        static void Q1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + ": hello world");
            }
        }

        static void Q2()
        {
            Console.Write("enter text: ");
            string text = Console.ReadLine();
            Console.Write("how many times? : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(text);
            }
        }

        static void Q3()
        {
            Console.Write("enter start: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter end: ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter increase: ");
            int increase = Convert.ToInt32(Console.ReadLine());
            for (int i = start; i <= end; i += increase)
            {
                Console.WriteLine(i);
            }
        }

        static void Q4()
        {
            int counter = 0;
            for (int i = 1; i<= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    counter++;
                }
            }
            Console.WriteLine("quantity : " + counter);
        }


        static void Q5()
        {
            int counter = 0;
            int i = 1;
            while (i <= 100)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    counter++;
                }
                i++;
            }
            Console.WriteLine("quantity : " + counter);

        }



        static void Main(string[] args)
        {

            /*
            

            Console.WriteLine("Loops - döngüler");
            Console.WriteLine("*************************");
            Console.WriteLine(" for Loops - for döngüsü");
            Console.WriteLine("*************************");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("*************************");

            for (int j = 0; j < 10; j = j + 2)
            {
                Console.WriteLine(j);
            }
            
            
            Console.WriteLine("*************************");
            for (int k = 10; k < 0; k--)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("********************"); 
            Console.WriteLine("while loops");
            Console.WriteLine("********************");

            int number = 0;
            while (number<7)
            {
                Console.WriteLine(number);
                number = number + 1;

            }
            
            Console.WriteLine("*********************");
            Console.WriteLine(" do while loops");
            Console.WriteLine("********************");

            int a = 0;
            do
            {
                Console.WriteLine(a);
            }
            while (a < 7);

            Console.WriteLine("*********************");
            Console.WriteLine("break keyword");
            Console.WriteLine("********************");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break; //döngülerden çıkmak için kullanılır. 
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("********************");

            int c = 0;
            while (c<7)
            {
                if (c == 4)
                {
                    break;
                }
                Console.WriteLine(c);
                c++;
            }

            Console.WriteLine("*********************");
            Console.WriteLine("continue keyword");
            Console.WriteLine("********************");

            for (int i = 0; i<10; i++)
            {
                if (i == 4)
                {
                    continue; //döngüyü yeniden başlatıp ama iç kısımdaki kodlara girmeyip adım atlamak için kullanılır. 
                }

                Console.WriteLine(i);
            }
            
             */
           

            // Q1();
            // Q2();
            // Q3();
            // Q4();
             Q5();
        }
    }
}
