bool isChild = false;
bool isTeenager = false;
bool isGrownup = false;

Console.WriteLine("What's your age?");
int age = Convert.ToInt32(Console.ReadLine());

isChild = age >= 0 && age <= 12;
isTeenager = age >= 13 && age <= 19;
isGrownup = age > 19;
    
Console.WriteLine(isChild);
Console.WriteLine(isTeenager);
Console.WriteLine(isGrownup);