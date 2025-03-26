using System;
using System.Diagnostics.Contracts;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _bottom = 1;
        _top = wholeNumber;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionValue()
    {
        string outcome = $"{_top}/{_bottom}";
        return outcome;
    }

    public double GetDecimalValue()
    {
        double num = _top/_bottom;
        return num;

    }
    
}