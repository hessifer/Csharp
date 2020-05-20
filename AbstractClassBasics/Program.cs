using System;

/*
    The abstract modifier indicates that the thing being modified has a 
    missing or incomplete implementation. The abstract modifier can be 
    used with classes, methods, properties, indexers, and events. Use 
    the abstract modifier in a class declaration to indicate that a 
    class is intended only to be a base class of other classes, not 
    instantiated on its own. Members marked as abstract must be 
    implemented by non-abstract classes that derive from the abstract class.
*/

abstract class Shape // abstract class (incomplete implementation of GetAreay)
{
    public abstract int GetArea(); // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract
}

class Square : Shape  // non-abstract base class
{
    int side;

    public Square(int n) => side = n; // Constructor

    // GetArea method is required to avoid a compile-time error.
    public override int GetArea() => side * side; // override from non-abstract derived class

    static void Main()
    {
        var sq = new Square(12);
        Console.WriteLine($"Area of the square = {sq.GetArea()}");
    }
}
// Output: Area of the square = 144