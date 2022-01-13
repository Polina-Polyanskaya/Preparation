namespace GuessNumber
{
    public class GuessNumberGame
    {
        readonly int max;
        readonly int maxTries;
        readonly GuessingPlayer guessingPlayer;

        public GuessNumberGame(int max = 100, int maxTries = 5, GuessingPlayer guessingPlayer = GuessingPlayer.Human)
        {
            this.max = max;
            this.maxTries = maxTries;
            this.guessingPlayer = guessingPlayer;
        }
        public void Start()
        {
            if (guessingPlayer == GuessingPlayer.Human)
                HumanGuesses();
            else 
                MachineGuesses();
        }

        public void HumanGuesses()
        {
            Random rand=new Random();
            int guessNumber = rand.Next(0, max);
            int lastGuess;
            int tries = 0;
            while(true)
            {
                Console.WriteLine("Guess the number!");
                lastGuess = int.Parse(Console.ReadLine());
                if (lastGuess == guessNumber)
                {
                    Console.WriteLine("Congrats! You guessed the number!");
                    break;
                }
                else if (lastGuess < guessNumber)
                    Console.WriteLine("My number is greater!");
                else
                    Console.WriteLine("My number is less!");
                tries++;
                if(tries==maxTries)
                {
                    Console.WriteLine($"You lost! Was guessed {guessNumber}");
                    break;
                }
            }
        }

        public void MachineGuesses()
        {
            Console.WriteLine("Enter a number that's going to be guessed by a computer.");
            int guessNumber = -1;
            while(guessNumber == -1)
            {
                int parsedNumber = int.Parse(Console.ReadLine());
                if (parsedNumber >= 0 && parsedNumber <= this.max)
                {
                    guessNumber = parsedNumber; 
                }
            }

            int lastGuess;
            int min = 0;
            int max = this.max;
            int tries = 0;
            while(true)
            {
                lastGuess = (max + min) / 2;
                Console.WriteLine($"Did you guess this number - {lastGuess}?");
                Console.WriteLine("If yes, enter 'y'");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("Super! I guessed your number!");
                    break;
                }
                else if (answer == "g")
                    min = lastGuess;
                else
                    max = lastGuess;
                tries++;
                if (tries == maxTries)
                {
                    Console.WriteLine("No tries anymore. I lost.");
                    break;
                }
            }
        }
    }
}
