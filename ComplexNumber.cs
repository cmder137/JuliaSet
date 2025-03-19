public struct ComplexNumber
{
    public double x;
    public double y;

    public ComplexNumber(double a, double b)
    {
        x = a;
        y = b;
    }

    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
    {
        ComplexNumber temp = new ComplexNumber(0, 0);

        temp.x = a.x + b.x;
        temp.y = a.y + b.y;

        return temp;
    }

    public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
    {
        ComplexNumber temp = new ComplexNumber(0, 0);

        temp.x = a.x * b.x - a.y * b.y;
        temp.y = a.x * b.y + a.y * b.x;

        return temp;
    }

    public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
    {
        ComplexNumber temp = new ComplexNumber(0, 0);

        temp.x = (a.x * b.x + a.y * b.y) / b.SquareOfAbs();
        temp.y = (a.y * b.x - a.x * b.y) / b.SquareOfAbs();

        return temp;
    }

    public double SquareOfAbs()
    {
        return (x * x) + (y * y);
    }

}


