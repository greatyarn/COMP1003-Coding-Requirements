using System;

namespace COMP1003
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Hello World!");

            //Question 2
            int integer = 5;
            Console.WriteLine(integer);

            //Question 3
            Console.Write("Hello World!" + integer);
            Console.WriteLine(); //To fix spacing
            //Question 4
            string number;

            Console.WriteLine("Write an int");
            number = Console.ReadLine();

            Console.WriteLine(number);

            //Question 5
            int total = 0;

            for (int i = 1; i <= 10; i++)
            {
                total = total + i;
            }

            Console.WriteLine(total);

            //Question 6
            int totalwhile = 1;
            int final = 0;

            while (totalwhile <= 10)
            {
                final = final + totalwhile;
                totalwhile++;
            }

            Console.WriteLine(final);

            //Question 7
            int[] intarray = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, };
            int num;

            var randomnum = new Random();
            num = randomnum.Next(0, 19);

            for (int i = 0; i < 10; i++)
            {
                intarray[i] = num;
                var randomnum2 = new Random();
                num = randomnum2.Next(0, 19);
            }


            for (int i = 0; i < intarray.Length; i++)
            {
                Console.WriteLine(intarray[i]);
            }

            //Question 8
            Array.Sort(intarray);
            Console.WriteLine(intarray[0]);

            //Question 9
            for (int i = 0; i < intarray.Length; i++)
            {
                if (intarray[i] == 5)
                {
                    Console.WriteLine("The value has been found");
                }
                else
                {
                    Console.WriteLine("The value has not been found");
                }
            }

            //Question 10
            string num1 = "";
            string num2 = "";

            Console.WriteLine("Type in your first number");
            num1 = Console.ReadLine();

            Console.WriteLine("Type in your second number");
            num2 = Console.ReadLine();

            Console.WriteLine("Number 1: " + num1);
            Console.WriteLine("Number 2: " + num2);

            int one;
            int two;

            int.TryParse(num1, out one);
            int.TryParse(num2, out two);

            one = one + two;
            two = one - two;
            one = one - two;

            Console.WriteLine("Number 1: " + one);
            Console.WriteLine("Number 2: " + two);

            //Question 11
            int[] intarraycopy = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, };

            for (int i = 0; i < intarray.Length; i++)
            {
                intarraycopy[i] = intarray[i];
            }

            for (int i = 0; i < intarraycopy.Length; i++)
            {
                Console.WriteLine(intarraycopy[i]);
            }

            //Question 12
            string first = "";
            string second = "";

            Console.WriteLine("Type in your first number");
            num1 = Console.ReadLine();

            Console.WriteLine("Type in your second number");
            num2 = Console.ReadLine();

            Console.WriteLine("Number 1: " + first);
            Console.WriteLine("Number 2: " + second);

            int tryparsefirst;
            int tryparsesecond;

            int.TryParse(num1, out tryparsesecond);
            int.TryParse(num2, out tryparsefirst);

            Console.WriteLine("Number 1: " + tryparsefirst);
            Console.WriteLine("Number 2: " + tryparsesecond);

            //Question 13
            Console.WriteLine(intarray[9]);

            //Question 14
            string[] source = { "Hello", "World", "How", "are", "you?" };
            string[] dest = { "", "", "", "", "" };

            for (int i = 0; i < source.Length; i++)
            {
                dest[i] = source[i];
            }

            for (int i = 0; i < dest.Length; i++)
            {
                Console.WriteLine(dest[i]);
            }

            //Question 15
            bool a = true;
            bool b = false;
            bool c = false;
            bool d;

            if (a && b || c)
            {
                d = true;
                Console.WriteLine("d is " + d);
            }
            else
            {
                d = false;
                Console.WriteLine("d is " + d);
            }
        }
    }
}
