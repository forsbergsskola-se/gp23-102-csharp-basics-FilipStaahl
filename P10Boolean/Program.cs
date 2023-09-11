/* Console.WriteLine("Type in your age.");
string userInput = Console.ReadLine();
int age = Convert.ToInt32(userInput);
bool isChild = age < 13;
Console.WriteLine($"You are concidered a child: {isChild}");
bool isTeenager = age >= 13 && age <= 19;
Console.WriteLine($"You are condidered a teenager: {isTeenager}");
bool isAdult = age > 19;
Console.WriteLine($"You are concidered a adult: {isAdult}"); */


using System.ComponentModel.Design;

/*GOAL assignment
Output:What's your age?
Input:31
Output:You are a grown-up.
Output:Give me another integer.
Input:20
Output:The maximum is: 31
Output:Your number is an odd number.*/

/* Console.WriteLine("What is your age?");
int  num = int.Parse(Console.ReadLine());
if (num > 18)
{
    Console.WriteLine("You are an adult.");
}
Console.WriteLine("Please give me another integer."); */



Console.Write("Enter the number of seconds: ");
int totalSeconds = Convert.ToInt32(Console.ReadLine());

double totalDaysFraction = (double)totalSeconds / 86400;

int days = totalSeconds / 86400;
totalSeconds %= 86400;
int hours = totalSeconds / 3600;
totalSeconds %= 3600;
int minutes = totalSeconds / 60;
int seconds = totalSeconds % 60;

 
Console.WriteLine($"Days: {days}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Seconds: {seconds}");
        
Console.WriteLine($"Formatted Time: {days}.{hours}:{minutes}:{seconds}");

Console.WriteLine($"Total Days as a Fraction: {totalDaysFraction}");




