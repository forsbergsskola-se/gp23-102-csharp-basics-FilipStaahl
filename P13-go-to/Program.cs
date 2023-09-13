/*PSEUDOCODE:
myNumber := random number between 1 and 100
explain rules to user
USER_TURN:
ask user for number
guess := user input

if myNumber is less than guess then
   tell user to guess lower
   go back to USER_TURN
end if

if myNumber is greater than guess then
   tell user to guess higher
   go back to USER_TURN
end if

if myNumber is equal to guess then
   tell user he won
end if*/

/* int gameWin = Random.Shared.Next(100);
Console.WriteLine("Let's play a game! Guess any whole number between 1 to 100!");
string userGuess = Console.ReadLine();
int.Parse(userGuess);
if (gameWin.Equals(userGuess))
{
   Console.WriteLine("That is the right number! Wanna play again?");
}
else
{
   
}
*/

/* Random random = new Random();
int myNumber = random.Next(1,101);

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I have chosen a random number between 1 and 100 and now you have to guess which one it is! Good Luck!");

Console.ReadLine(); */


Random random = new Random();
int myNumber = random.Next(1, 101);

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I'm thinking of a number between 1 and 100. Try to guess it!");

USER_TURN: 

Console.Write("Enter your guess: ");
string userInput = Console.ReadLine();

if (int.TryParse(userInput, out int guess))
{
   if (guess < 1 || guess > 100)
   {
      Console.WriteLine("Please guess a number between 1 and 100.");
      goto USER_TURN;
   }
   else if (myNumber < guess) 
   {
            Console.WriteLine("Guess lower!");
            goto USER_TURN; 
   }
   else if (myNumber > guess) 
   {
            Console.WriteLine("Guess higher!");
            goto USER_TURN; 
   }
   else
   {
            Console.WriteLine($"Congratulations! You guessed the number {myNumber} correctly!");
   }
}
else
{
         Console.WriteLine("Invalid input. Please enter a valid number.");
         goto USER_TURN; 
}

