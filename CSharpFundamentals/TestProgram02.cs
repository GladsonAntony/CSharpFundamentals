using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class TestProgram02
    {
        public void Test02()
        {
            Console.WriteLine("This is the second program to demonstrate the Variables Usage in CSharp");
            Console.WriteLine("Test for Integers Usage");
            Console.WriteLine("-------------------------------------");
            int a = 10;
            Console.WriteLine("Value of a = " + a);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------\n");


            Console.WriteLine("Test for String Usage");
            Console.WriteLine("-------------------------------------");
            String name = "Gladson Antony";
            Console.WriteLine("Name is " + name);
            Console.WriteLine($"Name is {name}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------\n");


            Console.WriteLine("Test for Var Usage");
            Console.WriteLine("-------------------------------------");
            var variable01 = 10;
            var variable02 = "Variable 02";
            Console.WriteLine("Value of variable01 = " + variable01);
            Console.WriteLine("Data Type of variable01 = " + variable01.GetType());
            Console.WriteLine("Value of variable02 = " + variable02);
            Console.WriteLine("Data Type of variable02 = " + variable02.GetType());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------\n");

            Console.WriteLine("Test for Dynamic Usage");
            Console.WriteLine("-------------------------------------");
            dynamic d1 = 10.04;
            Console.WriteLine("Value of d1 = " + d1);
            Console.WriteLine("Data Type of d1 = "+d1.GetType());
            d1 = "Test String Association";
            Console.WriteLine("Value of d1 = " + d1);
            Console.WriteLine("Data Type of d1 = " + d1.GetType());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------\n");
        }
    }
}
