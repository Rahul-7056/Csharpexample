using System;

namespace Csharpexample
{
    class Program
    {
        static void Main(string[] args)
        {   //Main function 
            Console.WriteLine("Enter your first name");
            string a = Console.ReadLine();
            Console.WriteLine("Enter your Last name");
            string b = Console.ReadLine();
            Console.WriteLine("Your Full Name is "+a+" "+b);
            //char
            char first;
            string name = a;
            first = name[0];
            Console.WriteLine("First letter of your name is => "+first+" <= first name is "+ a);
            Console.WriteLine(name[0]);
            //Compare the two numbers
            int num1, num2; bool result;
            Console.WriteLine("Enter First Number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("First Number is Greater");
                result = num1 > num2;
                Console.WriteLine("First Number is Greater which is "+result+" and number is "+num1);
            }
            else
            {
                Console.WriteLine("Second Number is Greater");
                result = num1 < num2;
                Console.WriteLine("Second Number is Greater which is " + result + " and number is " + num2);
            }
            //Constant Keyword
            const double pi = 3.1444; double area, circum;
            Console.WriteLine("Enter the value of Radius of Circle");
            int radius = int.Parse(Console.ReadLine());
            area = pi * (radius * radius);
            circum = 2 * pi * radius;
            Console.WriteLine("Area of Circle is "+area); 
            Console.WriteLine("Circumference of Cirle is "+circum); 
            
            


        }
    }
}
