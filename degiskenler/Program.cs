using System;
using System.Net.Http.Headers;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("variables - değişkenler");
            Console.WriteLine("*****************");
            Console.WriteLine("integer data types - integer veri tipleri");
            Console.WriteLine("*****************");
            sbyte number = 4;      //-128 to 127 değer aralığı
            byte number1 = 10;     //0 to 255
            short number2 = 20;    //-32,768 to 32,767
            int number3 = 15;      //-2,147,483,648 to 2,147,483,647
            long number4 = 200;    //-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

            ushort number5 = 12;   //0 to 65,535
            uint number6 = 30;     //0 to 4,294,967,295
            ulong number7 = 60;    //0 to 18,46,744,073,709,551,615

            Console.WriteLine("Sbyte: " + number);
            Console.WriteLine("byte: " + number1);
            Console.WriteLine("short: " + number2);
            Console.WriteLine("int: " + number3);
            Console.WriteLine("long: " + number4);
            Console.WriteLine("ushort: " + number5);
            Console.WriteLine("usint:" + number6);
            Console.WriteLine("ulong: " + number7);

            int age = 23;
            Console.WriteLine("age : " + age);

            Console.WriteLine("*************************");
            Console.WriteLine("floating data types - float veri tipleri");
            Console.WriteLine("*************************");

            float floatingNumber = 10.2f; //32-bit single- precision floating point type
            double doubleNumber = 10.2; //64-bit double - precision floating point type 
            decimal decimalNumber = 10.4m; //128- bit precise decimal values with 28-29 significant digits.

            Console.WriteLine("floating number : " + floatingNumber);
            Console.WriteLine("double number: "+ doubleNumber);
            Console.WriteLine("decimal number : "+ decimalNumber);

            Console.WriteLine("*************************");
            Console.WriteLine(" logical data types - mantıksal veri tipi");
            Console.WriteLine("*************************");

            bool isCorrect = true;
            Console.WriteLine("iscorrect" + isCorrect);

            Console.WriteLine("*************************");
            Console.WriteLine("character data types - karakter veri tipi");
            Console.WriteLine("*************************");

            char character = 'a';
            Console.WriteLine("character: " + character);

            Console.WriteLine("*************************");
            Console.WriteLine("constans - sabitler");
            Console.WriteLine("*************************");

            const int identityNumber = 1236459; //const: değer sabitleme için kullanılır. 
            Console.WriteLine("constant: " + identityNumber);

            Console.WriteLine("*************************");
            Console.WriteLine("Strings  - metinsel ifadeler");
            Console.WriteLine("*************************");

            string firstName = "hatice";
            string lastName = "nur";
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
