Console.WriteLine("How much would you like to withdraw?");
int count = int.Parse(Console.ReadLine());
int print = count;
Console.Write("Here is your money:");
Console.Write("Now you are broke :)))))");
PRINTAGAIN:
if (print > 0)
{
    Console.Write("$");
    print--;
    goto PRINTAGAIN;
}