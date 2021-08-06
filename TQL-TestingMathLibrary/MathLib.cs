using System;

namespace TQL_TestingMathLibrary {

    public class MathLib : IMathLibrary {

        public int Add(int i, int j) {
            return i + j;
        }

        public int Divide(int i, int j) {
            return i / j;
        }

        public int Factorial(int i) {
            var fact = 1;
            while(i > 1) {
                fact *= i--;
            }
            return fact;
        }

        public int Modulo(int i, int j) {
            return i - (i / j * j);
        }

        public ulong Multiply(int i, int j) {
            return (ulong)(i * j);
        }

        public int Power(int i, int j) {
            var pow = 1;
            for(var idx = 0; idx < j; idx++) {
                pow *= i; // pow = pow * i
            }
            return pow;
        }

        public int Square(int i) {
            return i * i;
        }

        public int Subtract(int i, int j) {
            return i - j;
        }
    }
}
