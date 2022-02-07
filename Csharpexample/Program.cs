using System;

namespace Csharpexample
{
    class Program
    {
        static void Main(string[] args)
        {   //Main function 
            //Console.WriteLine("Enter your first name");
            //string a = Console.ReadLine();
            //Console.WriteLine("Enter your Last name");
            //string b = Console.ReadLine();
            //Console.WriteLine("Your Full Name is "+a+" "+b);
            
            ////char
            //char first;
            //string name = a;
            //first = name[0];
            //Console.WriteLine("First letter of your name is => "+first+" <= first name is "+ a);
            
            ////Compare the two numbers
            //int num1, num2; bool result;
            //Console.WriteLine("Enter First Number");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number");
            //num2 = int.Parse(Console.ReadLine());
            //if (num1 > num2)
            //{
            //    Console.WriteLine("First Number is Greater");
            //    result = num1 > num2;
            //    Console.WriteLine("First Number is Greater which is "+result+" and number is "+num1);
            //}
            //else
            //{
            //    Console.WriteLine("Second Number is Greater");
            //    result = num1 < num2;
            //    Console.WriteLine("Second Number is Greater which is " + result + " and number is " + num2);
            //}
            
            ////Constant Keyword
            //const double pi = 3.1444; double area, circum;
            //Console.WriteLine("Enter the value of Radius of Circle");
            //int radius = int.Parse(Console.ReadLine());
            //area = pi * (radius * radius);
            //circum = 2 * pi * radius;
            //Console.WriteLine("Area of Circle is "+area); 
            //Console.WriteLine("Circumference of Cirle is "+circum);

            ////If Else Statement
            //Console.WriteLine("Do you want to see the Current Date & Time??");
            //Console.WriteLine("Type Yes or Y For see the Current Date & Time");
            //string ans = Console.ReadLine();
            //if (ans == "Yes" || ans == "Y")
            //{
            //    Console.WriteLine("Current Date & Time is " + DateTime.Now.ToString());
            //}
            //else if (ans == "N" || ans == "No")
            //{
            //    Console.WriteLine("It's okay :)"+a+"!!!!");
            //}
            //else
            //{
            //    Console.WriteLine("U have to enter Yes or No "+ a+"!!!!");
            //}

            ////Switch Case Statement
            //Console.WriteLine("Enter a number 1 to 5");
            //int con = int.Parse(Console.ReadLine());
            //switch (con)
            //{
            //    case 0:
            //        Console.WriteLine("Zero");
            //        break;
            //    case 1:
            //        Console.WriteLine("One");
            //        break;
            //    case 2:
            //        Console.WriteLine("Two");
            //        break;
            //    case 3:
            //        Console.WriteLine("Three");
            //        break;
            //    case 4:
            //        Console.WriteLine("Four");
            //        break;
            //    case 5:
            //        Console.WriteLine("Five");
            //        break;
            //    default:
            //        Console.WriteLine("Other Number");
            //        break;
            //}

            //// loops
            //while (con <= 10)
            //{
            //    Console.WriteLine("while loop "+con);
            //    con++;
            //}
            //for (con = 0; con < 15; con++)
            //{
            //    Console.WriteLine("for loop "+con);
            //}

            ////Foreach example
            //string[] colors = {"Red","Green","Blue","White","Black","Brown" };
            //foreach (string item in colors)
            //{
            //    Console.WriteLine(item);
            //}
            //Arrary 
            string[] colours; //declare an array
            int count = 0;
            while (true)
            {
                Console.WriteLine("Enter a Colour Name");
                colours = new string[] { Console.ReadLine() };
                Console.WriteLine(colours[0]);
                count++;
            
            }

        }
    }
}
