using System;

/*
C# suports single inheritance B : A
C# inheritance is transitive so you can have B : A, C : B, D: C and access fields/methods from A in D
static constructors, instance constructors, finalizers (GC) are not inherited from the base class
*/

public class A
{
   // private member, only accessible from within the clase or a nested derived class
   private int value = 10;

   public class B : A
   {
       public int GetValue()
       {
           // this will work as B is nested in the base class A
           return this.value; 
       }
   }
}

public class C : A
{
//    public int GetValue()
//    {
//        return this.value; // this throws an error since value has an accessor of private and C is not nested in A
//    }
}

public class Example
{
    public static void Main(string[] args)
    {
        var b = new A.B();
        Console.WriteLine(b.GetValue());
    }
}
// The example displays the following output:
//       10