
using System;
using System.Drawing;


namespace ConsoleApp1
{
    class program
    {
        // case sensitive
        // entry point
        public static void Main()
        {   //problem 1
            // int x = 10; single line comment
            /*  multiples line comment
             int y = 20;
             int sum = x + y;
             Console.WriteLine(sum);
             */
            //problem 2 -->> the code the fix
            int x = 10; int y = 34;
            Console.WriteLine(x + y);
            //problem 3 
            string FullName = "mohamed elsayed ashmawy hamada";
            int Age = 20;
            int Salary = 0;
            bool IsStudent = true;
            //problem 4
            point p1 = new point();
            p1.x = 20;
            point p2 = new point();
            p2 = p1;
            p2.x = 30;
            Console.WriteLine(p2.x); //result 30
            Console.WriteLine(p1.x); //result 30
            //problem 5
            int n1 = 15, n2 = 4;
            Console.WriteLine($"sum = {n1 + n2}");
            Console.WriteLine($"sub = {n1 - n2}");
            Console.WriteLine($"product = {n1 * n2}");
            Console.WriteLine($"div = {n1 / n2}");
            Console.WriteLine($"reminder = {n1 % n2}");
            //problem 5
            int num = int.Parse(Console.ReadLine());
            if (num > 10)
            {
                if (num % 2 == 0)
                    Console.WriteLine("the number is bigger than 10 and is even");
                }
            else
                Console.WriteLine("the number doesn't satisy the conditions");
            //problem 6 
            double num2 = 525.3245;
            int num3 = (int)num2;
            Console.WriteLine(num3);//525

            Console.WriteLine("enter your age");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                Console.WriteLine(" your age is " + result);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            //problmem 7 
            int num4 = 20;
            Console.WriteLine(num4++);// num4=21  -- result = 20
            Console.WriteLine(++num4);// num4=22  -- result = 22    


        }

    }
    class point
    {
       public int x;
    }
}

