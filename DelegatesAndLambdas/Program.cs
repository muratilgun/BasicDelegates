using System;

namespace DelegatesAndLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOp f = Add;
            f = Subtract;
            // Console.WriteLine(f(8,2));
            // CalculateAndPrint(2,1, f);
            // CalculateAndPrint(21,21,  int Add(int x, int y) { return x + y; });
            // CalculateAndPrint(21,21, delegate(int x, int y) { return x + y; });
            // CalculateAndPrint(21,21, (int x, int y)=> { return x + y; });
            // CalculateAndPrint(21,21, (int x, int y) => x + y );
            CalculateAndPrint(21,21, ( x, y) => x + y );
            CalculateAndPrint(21,21, ( x, y) => x - y );
            CalculateAndPrint(21,21, ( x, y) => x * y ); 

            CalculateAndPrint("A","B",(x,y)=> x+y);
            CalculateAndPrint<bool>(true,false,((bool b,bool b1) => b && b1 ));
        }
        //
        delegate T Combine<T>(T a, T b);

        delegate int MathOp(int x, int y);

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static void CalculateAndPrint<T>(T x, T y, Combine<T> f)
        {
            var result = f(x, y);
            Console.WriteLine(result);
        }
    }
}
