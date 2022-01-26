Console.WriteLine("Please pass me a seed (integer).");
int seedVar = Convert.ToInt32(Console.ReadLine());
Random random = new Random(seedVar);
Console.WriteLine("Three integers between 0 and 5:");
Console.WriteLine(random.Next(0, 5));
Console.WriteLine(random.Next(0, 5));
Console.WriteLine(random.Next(0, 5));

Console.WriteLine("Three integers between 0.0 and 0.5:");
Console.WriteLine(random.NextDouble() * 0.5);
Console.WriteLine(random.NextDouble() * 0.5);
Console.WriteLine(random.NextDouble() * 0.5);

Console.WriteLine("Three numbers between 0.2 and 0.7:");
Console.WriteLine(random.NextDouble() * (0.7 - 0.2) + 0.2);
Console.WriteLine(random.NextDouble() * (0.7 - 0.2) + 0.2);
Console.WriteLine(random.NextDouble() * (0.7 - 0.2) + 0.2);

Console.WriteLine("Give me a crit chance between 0.0 (0%) and 1.0 (100%)");
seedVar = Convert.ToInt32(Convert.ToSingle(Console.ReadLine()));

if (random.NextDouble() >= 0.5f)
{
    Console.WriteLine("No Crit");
}
else
{
    Console.WriteLine("Crit");
}

if (random.NextDouble() >= 0.5f)
{
    Console.WriteLine("No Crit");
}
else
{
    Console.WriteLine("Crit");
}

if (random.NextDouble() >= 0.5f)
{
    Console.WriteLine("No Crit");
}
else
{
    Console.WriteLine("Crit");
}

if (random.NextDouble() >= 0.5f)
{
    Console.WriteLine("No Crit");
}
else
{
    Console.WriteLine("Crit");
}

if (random.NextDouble() >= 0.5f)
{
    Console.WriteLine("No Crit");
}
else
{
    Console.WriteLine("Crit");
}