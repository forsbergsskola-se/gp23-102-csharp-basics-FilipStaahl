Console.WriteLine("Hello! Type in any amount of minutes and I will convert it into seconds!");
string userInput = Console.ReadLine();
int userNumber = int.Parse(userInput);
int x = userNumber * 60;
Console.WriteLine($"{userInput} would be {x} seconds!");
