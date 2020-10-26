using System;
using Xunit;
using CSharpXUnit_4Point2;

namespace XUnitTestProject1.test
{
    public class Program_Tests
    {
        [Theory]
        [InlineData(2,1)]
        public void DivideByTwo(int input,  int expected)
        {
            int output;
            output = Program.DivideByTwo(input);
        }
    }
}
