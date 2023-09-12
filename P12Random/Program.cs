Console.WriteLine("Please pass me a seed (integer).");
string userInput = Console.ReadLine();
int userSeed = int.Parse(userInput);
Random seed = new Random(userSeed);
Console.WriteLine(seed.Next(0, 5));
Console.WriteLine(seed.Next(0, 5));
Console.WriteLine(seed.Next(0, 5));

// ----------------------------------------------
Console.WriteLine(seed.NextDouble() * 0.5);
Console.WriteLine(seed.NextDouble() * 0.5);
Console.WriteLine(seed.NextDouble() * 0.5);

// ----------------------------------------------
Console.WriteLine("Three numbers between 0.2 and 0.7");
Console.WriteLine(seed.NextDouble() *0.5 +0.2); 
Console.WriteLine(seed.NextDouble() *0.5 + 0.2);
Console.WriteLine(seed.NextDouble() *0.5 + 0.2);    
// ----------------------------------------------
Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%, n00b!)");
Console.ReadLine();
if(Random.Shared.NextDouble() < 0.7)
{
    Console.WriteLine("Crit!");
}
else
{
    Console.WriteLine("git gud");
}