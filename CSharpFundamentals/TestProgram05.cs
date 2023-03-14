using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class TestProgram05
    {
        public void LinqExample()
        {
            int[] myNumber = { 10, 15, 23, 49, 09, 55, 05 };
            Console.WriteLine("\n\nTo Demonstrate the Use of LINQ NAMESPACE");
            Console.WriteLine("The Minimum Value of the defined Integer Array is " + myNumber.Min());
            Console.WriteLine("The Maximum Value of the defined Integer Array is " + myNumber.Max());
            Console.WriteLine("The Sum of the defined Integer Array is " + myNumber.Sum());
            Console.WriteLine("The Average Value of the defined Integer Array is " + myNumber.Average());
        }
    }
}
