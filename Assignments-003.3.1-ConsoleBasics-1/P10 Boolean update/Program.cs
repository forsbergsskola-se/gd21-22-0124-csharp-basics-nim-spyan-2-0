﻿namespace Boolean
{
    public class Program
    {
        static void Main()
        {
            bool isChild;
            bool isTeenager;
            bool isGrownup;

            isChild = false;
            isTeenager = false;
            isGrownup = false;


            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 0 && age <= 12)
            {
                isChild = true;
            }

            if (age >= 13 && age <= 19)
            {
                isTeenager = true;
            }

            if (age >= 20)
            {
                isGrownup = true;
            }

            Console.WriteLine();
            Console.WriteLine("Your a child: " + isChild);
            Console.WriteLine("Your a teenager: " + isTeenager);
            Console.WriteLine("Your a grownup: " + isGrownup);
        }
    }
}