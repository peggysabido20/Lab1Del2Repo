using System;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");

        Console.Write("What is your name? ");
        string sName = Console.ReadLine();

        Console.Write("Welcome " + sName + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No: ");
        string sAnswer = Console.ReadLine();

        if (sAnswer.ToLower() == "no")
        {

            Console.WriteLine("You are a coward " + sName);
        }
        else
        {
            Random rnd = new Random();
            int iCoin = 0;
            int iCount = 0;
            string sAnswerCoin = "";
            for (int j = 0; j < 5; j++)
            {
                iCoin = rnd.Next(10);
                Console.Write("Heads or Tails? ");
                sAnswerCoin = Console.ReadLine();
                if ((iCoin % 2) == 0)
                {
                    if (sAnswerCoin.ToLower() == "heads")
                    {
                        iCount++;
                        Console.WriteLine("Correct!");
                    }
                    else if (sAnswerCoin.ToLower() == "tails")
                    {
                        Console.WriteLine("Wrong!");
                    }
                    else
                    {
                        Console.WriteLine("Options are only Heads/Tails");
                    }
                }
                else
                {
                    if (sAnswerCoin.ToLower() == "tails")
                    {
                        iCount++;
                        Console.WriteLine("Correct!");
                    }
                    else if (sAnswerCoin.ToLower() == "heads")
                    {
                        Console.WriteLine("Wrong!");
                    }
                    else
                    {
                        Console.WriteLine("Options are only Heads/Tails");
                    }
                }
            }
            Console.WriteLine("Thank you " + sName + ". You got a score of " + iCount + "!");

        }



    }
}
