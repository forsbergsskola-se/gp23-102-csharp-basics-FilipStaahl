// Input (Console.WriteLine) -->[BlackBox (Algorithm)]--> Output(Console.ReadLine)
//                                          (Instructions)

// Exercise 1
// Ask the user for an input in km/h
// Print the result of converting the value to m/s
// x1000 / 60 / 60 = m/s from km/h
// With int its better to multiply first to avoid losing info
// With Float its better to divide first for the same reason
// Double means double the precision, not double the value

Console.WriteLine("Welcome to the km/h to m/s converter");

Console.WriteLine("Please enter a value in km/h");

string userInput = Console.ReadLine();

float userNumber = Convert.ToSingle(userInput);
Ç
float x = userNumber * 1000 / 60 / 60;

Console.WriteLine($"That would be {x} m/s");