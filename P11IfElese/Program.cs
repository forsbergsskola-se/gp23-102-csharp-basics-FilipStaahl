/*
Console.WriteLine("What is your age?");
string ageInput = Console.ReadLine();
int age = int.Parse(ageInput);

if (age < 13)
{
    Console.WriteLine("You are a child!");
}
else if (age > 19)
{
    Console.WriteLine("You are a adult!");
}
else if (age > 19)
{
    Console.WriteLine("You are an teenager!");
}

Console.WriteLine("Give me another interger!");
string numberInput = Console.ReadLine();
int number = int.Parse(numberInput);

if (number > age)
{
    Console.WriteLine($"the maximum is {number}");
    if (number % 2 == 0)
    {
        Console.WriteLine("It is a even number!");
    }
    else
    {
        Console.WriteLine("It is a odd number!");
    }
}
else
{
    Console.WriteLine($"The maximum is {age}");
    if (age % 2 == 0)
    {
        Console.WriteLine("It is a even number!");
    }
    else
    {
        Console.WriteLine("It is a odd number!");
    }

}
*/

/*
// printing output 
Console.WriteLine("What's your age?");

// console input && variable && type
string ageInput = Console.ReadLine();

// conversion && variable && type
int age = int.Parse(ageInput);

// conditional branching && boolean expressions && comparison operator
if (age < 13)
{
    Console.WriteLine("You are a child.");
}

else if (age >= 13 && age <= 19) // can be just (< 19) to simplify ("removes expressions)
{
    Console.WriteLine("You are a teen.");
}

else if (age > 19) // can be just "else" and remove "if age (age > 19)" to simplify
{
    Console.WriteLine("You are an adult.");
}

Console.WriteLine("Give me another integer");
string maximumNumber = Console.ReadLine();
int number = int.Parse(maximumNumber);

// number or age (whatever is greater)
int max; //read like number > age? else number : age
if (number > age)
{
    max = number;
}
else
{
    max = age;
}

{
    Console.WriteLine($"The maximum is {max}");
    if (max % 2== 0)
    {
        Console.WriteLine("It's an even number");
    }
    else
    {
        Console.WriteLine("It's an odd number");
    }
}
*/

Console.WriteLine("Give me a number and Ill convert it to a grade!");
int numericalGrade = int.Parse(Console.ReadLine());

