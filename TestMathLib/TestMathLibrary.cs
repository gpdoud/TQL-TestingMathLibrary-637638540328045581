using System;

using TQL_TestingMathLibrary;

using Xunit;

namespace TestMathLib {

    public class TestMathLibrary {

        [Theory]
        [InlineData(2, 3, 0)]
        [InlineData(1, 0, 0)]
        public void TestDivide(int i, int j, int ans) {
            var mathLib = new MathLib();
            if(j == 0) {
                Assert.ThrowsAny<DivideByZeroException>(() => mathLib.Divide(i, j));
                return;
            }
            Assert.Equal(ans, mathLib.Divide(i, j));
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(1000000, 5000, 705032704)]
        public void TestMultiple(int i, int j, long ans) {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Multiply(i, j));
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(6, 2, 8)]
        [InlineData(int.MaxValue, int.MinValue, -1)]
        [InlineData(int.MaxValue, 1, int.MinValue)]
        public void TestAdd(int i, int j, int ans) {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Add(i, j));
        }

        [Theory]
        [InlineData(1, 2, -1)]
        public void TestSubtract(int i, int j, int ans) {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Subtract(i, j));
        }
    }
}
