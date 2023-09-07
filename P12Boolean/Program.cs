Console.WriteLine("Type in your age.");
string userInput = Console.ReadLine();
int age = Convert.ToInt32(userInput);
bool isChild = age < 0 - 13;
Console.WriteLine($"You are concidered a child: {isChild}");
bool isTeenager = age >= 13 && age <= 19;
Console.WriteLine($"You are condidered a teenager: {isTeenager}");
bool isAdult = age > 19;
Console.WriteLine($"You are concidered a adult: {isAdult}");