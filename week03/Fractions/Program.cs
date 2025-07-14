using System;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {

        /* Fraction myFraction = new Fraction();
         myFraction.Settop(3);
         myFraction.Setbottom(4);

         int topValue = myFraction.Gettop();
         int bottomValue = myFraction.Getbottom();

         Console.WriteLine($"Top: {topValue} ");
         Console.WriteLine($"Bottom: {bottomValue}"); */

        Fraction f1 = new Fraction(1);
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 5);


        Console.WriteLine(f1.GetFractionString()); 
        Console.WriteLine(f1.GetDecimalValue());     
        Console.WriteLine(f2.GetFractionString());   
        Console.WriteLine(f2.GetDecimalValue());   
        Console.WriteLine(f3.GetFractionString());   
        Console.WriteLine(f3.GetDecimalValue());     
        Console.WriteLine(f4.GetFractionString());   
        Console.WriteLine(f4.GetDecimalValue());     


    }  
}