// printing output
Console.WriteLine("What's your age?");
// console input && variable && type
string ageInput = Console.ReadLine();

int age = int.Parse(ageInput);

if (age < 13)
{
    Console.WriteLine("You are a child.");
}
else if (age <= 19)
{
    Console.WriteLine("You are a teen.");
}
else
{
    Console.WriteLine("You are an adult.");
}

Console.WriteLine("Give me another integer.");
string numberInput = Console.ReadLine();
int number = int.Parse(numberInput);

if (number > age)
{
    Console.WriteLine($"The maximum is {number}.");
}
else
{
    Console.WriteLine($"The maximum is {age}.");
}

if (number % 2 == 0)
{
    Console.WriteLine("It's an even number.");
}
else
{
    Console.WriteLine("It's an odd number.");
}
