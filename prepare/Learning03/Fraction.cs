class Fraction
{
    private int _numerator;
    private int _denominator;
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _denominator = denominator;
        _numerator = numerator;
    }
    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    public int GetTop()
    {
        Console.WriteLine(_numerator);
        return _numerator;
    }
    public int GetBottom()
    {
        Console.WriteLine(_denominator);
        return _denominator;
    }
    public void SetTop(int newTop)
    {
        _numerator = newTop;
    }
    public void SetBottom(int newBottom)
    {
        _denominator = newBottom;
    }
    public string GetFraction()
    {
        string fraction = $"{_numerator}/{_denominator}";
        Console.WriteLine(fraction);
        return fraction;
    }
    public double GetDecimal()
    {
        double decimalValue = (double)_numerator / (double)_denominator;
        Console.WriteLine(decimalValue);
        return decimalValue;        
    }

}
