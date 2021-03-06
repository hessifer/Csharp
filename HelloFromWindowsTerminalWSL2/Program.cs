﻿using System;

/*
C# suports single inheritance B : A

C# inheritance is transitive so you can have B : A, C : B, D: C and access fields/methods from A in D

static constructors, instance constructors, finalizers (GC) are not inherited from the base class

*/

public class A
{
   private int value = 10;

   public class B : A
   {
       public int GetValue()
       {
           return this.value; // this will work as B is nested in the base class A
       }
   }
}

public class C : A
{
//    public int GetValue()
//    {
//        return this.value;
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