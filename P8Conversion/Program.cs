Console.WriteLine("Give me a number.");
string number = Console.ReadLine();
double d = double.Parse(number);
Console.WriteLine(number);
int i = (int)d;
Console.WriteLine(i);
int o = int.Parse(number);
Console.WriteLine(o);

//First: Try to assigning it. Error? then
//Second: Try casting it. Error? Then
//Third: Try parsing it. Error? Then
//Last Resort: Try Converting it. Error? You're living in Spain without a S.


