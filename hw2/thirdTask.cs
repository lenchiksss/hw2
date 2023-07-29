struct DecimalNumber
{
    private int decimalnumber;

    public int DecimalValue
    {
        get { return decimalnumber; }
        set { decimalnumber = value; }
    }

    public DecimalNumber(int value)
    {
        decimalnumber = value;
    }

    public string ToBinary()
    {
        return Convert.ToString(decimalnumber, 2);
    }

    public string ToOctal()
    {
        return Convert.ToString(decimalnumber, 8);
    }

    public string ToHex()
    {
        return Convert.ToString(decimalnumber, 16);
    }
}