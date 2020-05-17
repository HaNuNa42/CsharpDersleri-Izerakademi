using System;

namespace userInput
{
    class Program
    {


        static void Q1()
        {

            Console.Write("firstname: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("lastname: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("hello {0} {1}", firstName, lastName);
        }

        static void Q2()
        {
                Console.Write("first number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("second number: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                int sum = number1 + number2;
                int sub = number1 - number2;
                int mul = number1 * number2;
                double div = number1 / (double)number2;
                Console.WriteLine("{0} and {1} of sum : {2} ", number1, number2, sum);
                Console.WriteLine("{0} and {1} of sub : {2} ", number1, number2, sub);
                Console.WriteLine("{0} and {1} of mul : {2} ", number1, number2, mul);
                Console.WriteLine("{0} and {1} of div : {2} ", number1, number2, div);

            }

        static void Q3()
        {
            Console.Write("enter weight : ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter height : ");
            int height = Convert.ToInt32(Console.ReadLine());
            int area = weight * height;
            int env = 2 * (weight + height);
            Console.WriteLine("area : " + area);
            Console.WriteLine("env: " + env);

        }



        static void Q4()
        {
            const double pi = 3.14;
            Console.Write("enter radius : ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = pi * radius * radius;
            double env = 2 * pi * radius;
            Console.WriteLine("area : " + area);
            Console.WriteLine("env: " + env);

        }



            static void Main(string[] args)
            {

            /*
            Console.WriteLine("User input");
            Console.WriteLine("enter username: ");
            string userName = Console.ReadLine(); //kullanıcıdan alacağımız veriyi programın okuması için readline komutunu kullanıyoruz.
            Console.WriteLine("Username: "+ userName);

            Console.WriteLine("enter your age:");
            int age = Convert.ToInt32(Console.ReadLine()); // convert tip dönüşümü işlemlerinde kullanılır. string ifade olduğu için int veri tipine dönüştürmemiz gerekli.
            Console.WriteLine("your age is: " + age);
            */

            // Q1();
            // Q2();
            // Q3();
            Q4();

            }
        }
    
}
