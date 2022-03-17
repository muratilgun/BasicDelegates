using System;

namespace DelegatesAndLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOp f = Add;
            f = Subtract;
            Console.WriteLine(f(8,2));
        }

        delegate int MathOp(int x, int y);

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }
        
    }
}
