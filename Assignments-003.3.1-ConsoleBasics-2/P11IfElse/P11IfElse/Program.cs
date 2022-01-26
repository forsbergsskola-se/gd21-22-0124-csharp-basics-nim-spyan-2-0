Console.WriteLine("What's your age?");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 0 && age <= 12)
{
    Console.WriteLine("You are a Child.");
}
else if (age >= 13 && age <= 19)
{
    Console.WriteLine("You are a Teenager.");
}
else
{
    Console.WriteLine("You are a grown-up.");
}

Console.WriteLine("Give me another integer.");
int newInt = Convert.ToInt32(Console.ReadLine());

if (age > newInt)
{
    Console.WriteLine("The maximum is: " + age);
}
else
{
    Console.WriteLine("The maximum is: " + newInt);
}

if (age % 2 == 0)
{
    Console.WriteLine("Your number is an even number.");
}
else
{
    Console.WriteLine("Your number is an odd number.");
}