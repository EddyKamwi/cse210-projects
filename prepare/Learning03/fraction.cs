class Fraction
{
    private int _top;
    private int _bottom;

    // constructors
    public Fraction()
    {
        _top = 0;
        _bottom = 0;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // methods
    public void SetTop(int top)
    {
        _top = top;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    private int GetBottom()
    {
        return _bottom;
    }
    private int GetTop()
    {
        return _top;
    }

    public string GetFractionString()
    {
        string fract = $"{GetTop()}/{GetBottom()}";

        return fract;
    }
    public double GetDecimalValue()
    {
        double fract = (double)_top / (double)_bottom;

        return fract;
    }

}