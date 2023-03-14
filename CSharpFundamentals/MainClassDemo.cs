using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class MainClassDemo
    {
        public static void Main(string[] args)
        {
            TestProgram01 testProgram01 = new TestProgram01();
            testProgram01.FirstExample();

            TestProgram02 testProgram02 = new TestProgram02();
            testProgram02.TestVariablesType();

            TestProgram03 testProgram03 = new TestProgram03();
            testProgram03.ArraysExample();

            TestProgram04 testProgram04 = new TestProgram04();
            testProgram04.TestArrayList();

            TestProgram05 testProgram05 = new TestProgram05();
            testProgram05.LinqExample();
        }
    }
}
