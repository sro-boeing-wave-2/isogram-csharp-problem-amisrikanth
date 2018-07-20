using System;
using Xunit;
using isogram_csharp_problem_amisrikanth;

namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Class1.Validate(""));
        }
        [Fact]
        public void Test2()
        {
            Assert.True(Class1.Validate("isogram"));
        }
        [Fact]
        public void Test3()
        {
            Assert.False(Class1.Validate("eleven"));
        }
        [Fact]
        public void Test4()
        {
            Assert.True(Class1.Validate("subdermatoglyphic"));
        }
        [Fact]
        public void Test5()
        {
            Assert.True(Class1.Validate("Alphabet"));
        }
        [Fact]
        public void Test6()
        {
            Assert.True(Class1.Validate("thumbscrew-japingly"));
        }
        [Fact]
        public void Test7()
        {
            Assert.True(Class1.Validate("six-year-old"));
        }
        [Fact]
        public void Test8()
        {
            Assert.True(Class1.Validate("Sr ik an th"));
        }
    }
}
