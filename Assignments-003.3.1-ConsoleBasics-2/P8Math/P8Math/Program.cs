Console.WriteLine("Give me your first number.");

string numOne = Console.ReadLine();
double first  = Convert.ToDouble(numOne);

Console.WriteLine("Give me your second number.");

string numTwo = Console.ReadLine();
double second = Convert.ToDouble(numTwo);

Console.WriteLine("Max:");
Console.WriteLine(Math.Max(first, second));
Console.WriteLine("Min:");
Console.WriteLine(Math.Min(first, second));
Console.WriteLine("Sqrt:");
Console.WriteLine(Math.Sqrt(first));
Console.WriteLine("Abs:");
Console.WriteLine(Math.Abs(first));
Console.WriteLine("Round:");
Console.WriteLine(Math.Round(first));
Console.WriteLine("Floor:");
Console.WriteLine(Math.Floor(first));
Console.WriteLine("Ceil:");
Console.WriteLine(Math.Ceiling(first));
Console.WriteLine("Clamp:");
Console.WriteLine(Math.Clamp(first, 0, second));
Console.WriteLine("Pow:");
Console.WriteLine(Math.Pow(first, second));