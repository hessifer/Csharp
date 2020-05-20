using System;

/*
C# suports single inheritance B : A
C# inheritance is transitive so you can have B : A, C : B, D: C and access fields/methods from A in D
static constructors, instance constructors, finalizers (GC) are not inherited from the base class
*/

public class A
{
    /*
        1. Private members are only accessible from within a nested derived class
        2. Protected members are visible only in derived classes.
        3. Internal members are visible only in derived classes that are located in the same 
           assembly as the base class. They are not visible in derived classes located in a 
           different assembly from the base class.
        4. Public members are visible in derived classes and are part of the derived class' public interface. Public inherited members can be called just as if they are defined in the derived class. In the following example, class A defines a method named Method1, and class B inherits from class A. The example then calls Method1 as if it were an instance method on B.
    */
   private int value = 10;
   public string color = "blue";

   // Using 'virtual' here since this is not an abstract class (abstract class required for 'abstract member')
   public virtual void SayHello() // use 'virtual' keyword here so that we can override in base class
   {
       Console.WriteLine("Hello World!");
   }

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

    public string GetValue()
    {
        return this.color; // this works since inheritance is transitive and the field color has a accessor of public
    }

    // let's override a member from Class A, you must use the 'virtual' keyword
    public override void SayHello()
    {
        Console.WriteLine("Wazzup!");
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        var b = new A.B();
        var c = new C();

        Console.WriteLine(b.GetValue());
        Console.WriteLine(c.GetValue());
        c.SayHello();
    }
}
// The example displays the following output:
//       10