
var decNumber = new DecimalNumber(1337);

decNumber.Show();
Console.WriteLine($"Number in binary system: {decNumber.ConvertToBinary()}");
Console.WriteLine($"Number in octal: {decNumber.ConvertToOctal()}");
Console.WriteLine($"Number in hexadecimal: {decNumber.ConvertToHexadecimal()}");