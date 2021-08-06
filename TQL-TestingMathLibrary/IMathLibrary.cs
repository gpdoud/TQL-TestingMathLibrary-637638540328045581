using System;
using System.Collections.Generic;
using System.Text;

namespace TQL_TestingMathLibrary {
    interface IMathLibrary {

        int Add(int i, int j);
        int Subtract(int i, int j);
        long Multiply(int i, int j);
        int Divide(int i, int j);
        int Power(int i, int j);
        int Square(int i);
        int Factorial(int i);
        int Modulo(int i, int j);


    }
}
