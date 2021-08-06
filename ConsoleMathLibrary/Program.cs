using System;

using TQL_TestingMathLibrary;

namespace ConsoleMathLibrary {
    class Program {
        static void Main(string[] args) {
            var ml = new MathLib();
            var addVal = ml.Add(5, 7);
            var subVal = ml.Subtract(9, 3);
            var mulVal = ml.Multiply(3, 7);
            var divVal = ml.Divide(13, 4);
            var powVal = ml.Power(2, 4);
            var sqrVal = ml.Square(13);
            var factVal = ml.Factorial(6);
            var modVal = ml.Modulo(10, 3);
        }
    }
}
