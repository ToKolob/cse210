using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction a = new Fraction();
        Fraction b = new Fraction(6);
        Fraction c = new Fraction(6, 7);

        a.GetFraction();
        a.GetDecimal();
        b.GetFraction();
        b.GetDecimal();
        c.GetFraction();
        c.GetDecimal();



    }
}
