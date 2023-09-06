/* Implement a program that takes two integers as input and displays their division result as a float.
 
 Console.WriteLine("Welcome to the KM/h to M/s Converter!");
Console.WriteLine("Please type in a amount of KM/H that you want to convert");
string userInput = Console.ReadLine();
float userKM = float.Parse(userInput);
float x = userKM / 3600 * 1000;
Console.WriteLine($" The answer to {userInput} KM/h in M/s is {x}");*/

/* Implement a program that takes two integers as input and displays their division result as a float.
Console.WriteLine("Hello and welcome to your calculator!");
Console.WriteLine("What numbers can I divide for you?");
string userInputX = Console.ReadLine();
int x = Convert.ToInt32(userInputX);
Console.WriteLine("Please add your second number");
string userInputY = Console.ReadLine();
int y = Convert.ToInt32(userInputY);
float answer = (float) x / y;
Console.WriteLine($"{userInputX} divided by {userInputY} equals {answer}");*/


/* Write a program that calculates the remainder of dividing two integers and displays the result.
Console.WriteLine("Hello and welcome to your calculator!");
Console.WriteLine("What numbers can I divide for you?");
string userInputX = Console.ReadLine();
int x = Convert.ToInt32(userInputX);
Console.WriteLine("Please add your second number");
string userInputY = Console.ReadLine();
int y = Convert.ToInt32(userInputY);
int answer = y % x;
Console.WriteLine($"{userInputX} divided by {userInputY} equals {answer}"); *