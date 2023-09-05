using System.Globalization;

float number = 5.6f;
Console.WriteLine("Give me a number.");
var input= Console.ReadLine();
Console.WriteLine(number);
double fractionalNumber = 5;
Console.WriteLine(fractionalNumber);
fractionalNumber = Convert.ToDouble(input, CultureInfo.InvariantCulture);
Console.WriteLine(fractionalNumber);



