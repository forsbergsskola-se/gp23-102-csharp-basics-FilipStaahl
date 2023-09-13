
Console.WriteLine("Welcome to the km/h to m/s converter");

Console.WriteLine("Please enter a value in km/h");

string userInput = Console.ReadLine();

float userNumber = Convert.ToSingle(userInput);

float x = userNumber * 1000 / 60 / 60;

Console.WriteLine($"That would be {x} m/s");