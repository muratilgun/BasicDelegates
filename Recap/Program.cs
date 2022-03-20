using System;
#region Action

//Action a = () => Console.WriteLine("Hi");
//a();

//Action<int> a2 = n => Console.WriteLine(n * n);
//a2(42);

//Action<string, string> a3 = (s1, s2) => Console.WriteLine(s1 + s2);
//a3("Foo", "Bar");
#endregion

#region Func

// Func<int> f = () => 42;
// Console.WriteLine(f());

// Func<int, int> f2 = n => n * n;
// Console.WriteLine(f2(42));

// Func<int, int, bool> f3 = (n1, n2) => n1 == n2;
// Console.WriteLine(f3(42,42));

#endregion

#region Closures


Func<int, int> calculator = CreateCalculator();
Console.WriteLine(calculator(2));

// int CalculateSomething(int n)
// {
//    if (n == 0) return n;

//    var factor = 42;
//    return factor * CalculateSomething(n-1);
// }

int CalculateSomething(int n)
{
    if (n == 0) return n;

    var factor = 42;
    return factor * CalculateSomething(n - 1);
}

Func<int, int> CreateCalculator()
{
    var factor = 42;
    return n => n * factor;
}

BestFriends CreateCalculatorInternal()
{
    return new BestFriends { factor = 42 };
}

class BestFriends
{
    public int factor;
    public int Calculator(int n) => n * factor;

}

#endregion