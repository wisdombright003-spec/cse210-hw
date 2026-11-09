public class Fraction
{
    private int _top;
    private int _buttom;

    public Fraction()
    {
         _top = 1;
         _buttom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _buttom = 1;
    }

    public Fraction(int top, int buttom)
    {
        _top = top;
        _buttom = buttom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetButton()
    {
        return _buttom;
    }

    public void SetButtom(int buttom)
    {
        _buttom = buttom;
    }
    public string GetFractionString()
    {
        return _top + "/" +_buttom;
    }

    public double GetDesimalValue()
    {
        return (double)_top / _buttom;
    }

}