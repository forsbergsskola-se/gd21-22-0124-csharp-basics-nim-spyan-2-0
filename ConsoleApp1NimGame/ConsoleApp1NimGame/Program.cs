using System.ComponentModel.Design.Serialization;

namespace Nim
{
    class Program
    {
        static void Main()
        {
            int currentMatch = 24;
            string match = "||||||||||||||||||||||||"

            void MatchController(int changeMatch)
            {
                matches = "";
                currentMatches -= changeMatch;
                int i = 0;
                while (i < currentMatches)
                {
                    matches += "|";
                    ++i;
                }
            }

            Console.WriteLine("Choose to pick 1, 2, or 3 matches! The player that picks the last match looses.");

            while (currentMatches != 100)
            {
                //Check if game is over
                if (currentMatches == 1) goto lose;
                else if (currentMatches <= 0) goto win;

                //Player turn
                Console.WriteLine("Do you want to draw 1, 2 or 3 matches?");
                fuckup:
                int changeMatch = Convert.ToInt32(Console.ReadLine());
                if (changeMatch > 3 || changeMatch < 1)
                {
                    Console.WriteLine("please only type 1, 2 or 3");
                    goto fuckup;
                }

                MatchControl(changeMatch);
                Console.WriteLine($"You drew {changeMatch} matches,");
                Console.WriteLine(matches);

                //Check if game is over
                if (currentMatches == 1) goto win;
                else if (currentMatches <= 0) goto lose;

                //Ai turn
                int aiNum = random.Next(1, 4);
                changeMatch = aiNum;
                MatchControl(changeMatch);
                Console.WriteLine($"The ai drew {changeMatch} matches,");
                Console.WriteLine(matches);


                //Game over
                win:
                Console.WriteLine("You win");
                return;
                lose:
                Console.WriteLine("You lose");
            }
        }
    }
}
