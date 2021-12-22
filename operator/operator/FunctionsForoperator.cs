using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_operator
{
    class FunctionsForoperator
    {
        //산술 연산
        //덧셈
        static public int Sum(int a, int b)
        {
            return a + b;
        }
        static public int Sub(int a, int b)
        {
            return a - b;

        }
        static public int Div(int a, int b)
        {
            return a / b;
        }
        static public int Mul(int a, int b)
        {
            return a * b;
        }
        static public int Increase(int a)
        {
            return a++;
        }
        static public int Decrease(int a)
        {
            return a--;
        }
        static public bool IsSame(int a, int b)
        {
            return a == b;
        }
        static public bool IsDifferent(int a, int b)
        {
            return a != b;
        }
        static public bool IsBigger(int a, int b)
        {
            return a < b;
        }
        static public bool IsBiggerOrSame(int a, int b)
        {
            return a <= b;
        }
        static public bool IsSmaller(int a, int b)
        {
            return a > b;
        }
        static public bool IsSmallerOrSame(int a, int b)
        {
            return a >= b;
        }
        static public int PlusBToA(int a, int b)
        {
            return a <= b;
        }
    }
}
