int Match = 24;

Console.WriteLine("Choose to pick 1, 2, or 3 matches! The player that picks the last match looses.");

while (Match > 1)
{
    Console.WriteLine("Do you want to pick 1, 2, or 3 Matches?");
    
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        Match--;
    }
    else if (choice == 2)
    {
        Match--;
        Match--;
    }
    else if (choice == 3)
    {
        Match--;
        Match--;
        Match--;
    }
    else
    {
        Console.WriteLine("You can't do that!");
    }
    Console.WriteLine(Match);
}
