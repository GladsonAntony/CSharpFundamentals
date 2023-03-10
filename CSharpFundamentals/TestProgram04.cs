using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class TestProgram04
    {
        public void TestArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Pokemon");
            arrayList.Add("Naruto");
            arrayList.Add("DragonBall Z");
            arrayList.Add("One Piece");
            arrayList.Add("Bleach");

            int arrayListSize = arrayList.Count;

            Console.WriteLine("Total no of Items inside arrayList = "+arrayListSize);

            Console.WriteLine("\n\nTo Print the Values using For Loop");

            //Use of For Loop for ArrayList Example
            for (int i = 0; i < arrayListSize; i++)
            {
                Console.WriteLine("Array item at arrayList["+i+"] is "+arrayList[i]);
            }

            // Use of ForEach for ArrayList Example
            Console.WriteLine("\n\nTo Print the Values using ForEach");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);                
            }

            //To Search the Values
            Console.WriteLine("\n\nTo search the Values present in the ArrayList");

            Console.WriteLine(arrayList.Contains("One Piece"));
            Console.WriteLine(arrayList.Contains("My Hero Academia"));

            //To Sort the Values
            Console.WriteLine("\n\nTo sort the Values present in the ArrayList");
            arrayList.Sort();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
