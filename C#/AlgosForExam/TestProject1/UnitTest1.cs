using System;
using Xunit;
using AlgosForExam;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            SumThings temp = new();

            int expected = 99;

            int actual = temp.SummingNumbers(45, 54);

            Assert.Equal(expected, actual);
        }
    }
}
