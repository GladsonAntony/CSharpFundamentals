using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class TestProgram03
    {
        public void ArraysExample()
        {
            String[] arr01 = { "One", "Piece", "is", "the", "Best", "Anime", "in", "the", "World" };
            int[] arr02 = { 1, 9, 32, 78, 59 };

            String[] arr03 = new string[5];
            arr03[0] = "One";
            arr03[1] = "Piece";
            arr03[2] = "Best";

            Console.WriteLine("Printing the Values of Arr01..........");
            for (int i = 0; i < arr01.Length; i++)
            {
                Console.WriteLine("Value of arr01 at "+ i +" th index is '"+arr01[i]+"'\n");

                if (arr01[i] == "World")
                {
                    Console.WriteLine("Match Found\n\n");
                    break;
                }                
            }

            Console.WriteLine("Printing the Values of Arr02..........");
            for (int j = 0; j < arr02.Length; j++) 
            {
                Console.WriteLine("Value of arr02 at " + j + " th Index is '"+arr02[j]+"'\n");
            }
        }
    }
}
