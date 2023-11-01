namespace Homework9;
using System;
class HumanPlayer
{
    private int points;
    public HumanPlayer(int initial)
    {
        points = initial;
    }

    public int GetPoints()
    {
        return points;
    }

    public void WinRound()
    {
        points += 5;
    }

    public void LoseRound()
    {
        points -= 5;
    }

    public string HumanDecision()
    {
        Console.WriteLine("Please input your choice: rock paper or scissors.");
        return Console.ReadLine().ToLower();
    }
}

class ComputerPlayer
{
    private string[] shapes = { "rock", "paper", "scissors" };

    public string ComputerDecision()
    {
        Random random = new Random();
        int index = random.Next(shapes.Length);
        return shapes[index];
    }
}

class RockPaperScissors
{
    static void Main(string[] args)
    {
        HumanPlayer humanPlayer = new HumanPlayer(5);
        ComputerPlayer computerPlayer = new ComputerPlayer();

        while (humanPlayer.GetPoints() > 0)
        {
             Console.WriteLine("****Rock Paper Scissors, Start!!****");
            Console.WriteLine($"Your points: {humanPlayer.GetPoints()}");
            string humanChoice = humanPlayer.HumanDecision();
            string computerChoice = computerPlayer.ComputerDecision();
            Console.WriteLine($"-->Your Decision: {humanChoice}");
            Console.WriteLine($"-->Computer Decision: {computerChoice}");
            if (humanChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (
                (humanChoice == "rock" && computerChoice == "scissors") ||
                (humanChoice == "paper" && computerChoice == "rock") ||
                (humanChoice == "scissors" && computerChoice == "paper")
            )
            {
                humanPlayer.WinRound();
                Console.WriteLine("You win!");
            }
            else
            {
                humanPlayer.LoseRound();
                Console.WriteLine("You lose!");
            }

            Console.WriteLine("Play again? Insert (y) to continue, or insert n to exit.");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain != "y")
            {
                break;
            }
        }

        Console.WriteLine("Sorry you dont have enough points, thanks for playing.");
        Console.WriteLine("Thanks for playing");
    }
}
