using System;

public struct DecimalNumber
{
    private int _number;

    public DecimalNumber(int number)
    {
        _number = number;
    }
    public string ConvertToBinary()
    {
        return Convert.ToString(_number, 2);
    }
    public string ConvertToOctal()
    {
        return Convert.ToString(_number, 8);
    }
    public string ConvertToHexadecimal()
    {
        return Convert.ToString(_number, 16).ToUpper();
    }
    public void Show()
    {
        Console.WriteLine($"Decimal number: {_number}");
    }
}