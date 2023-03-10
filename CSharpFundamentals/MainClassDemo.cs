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
            testProgram01.Test01();

            TestProgram02 testProgram02 = new TestProgram02();
            testProgram02.Test02();

            TestArraysExample example = new TestArraysExample();
            example.example01();
        }
    }
}
