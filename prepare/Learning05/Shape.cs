using System.ComponentModel.DataAnnotations;

public class Shape
{
    private string _color;
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public virtual double GetArea(double l=0, double w=0)
    {
        return l*w;
    }

}