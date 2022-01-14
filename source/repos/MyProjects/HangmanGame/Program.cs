using HangmanGame;

HangmanGame.HangmanGame game=new HangmanGame.HangmanGame();
string word = game.GenerateWord();
Console.WriteLine($"The word consistes of {word.Length}");
Console.WriteLine("Try to guess the world");

while(game.GameStatus==GameStatus.InProgress)
{
    Console.WriteLine("Pick a letter");
    //char c = (char)Console.Read();
    char c = Console.ReadLine().ToCharArray()[0];
    string curState=game.GuessLetter(c);
    Console.WriteLine(curState);

    Console.WriteLine($"Remaining tries = {game.RemainingTries}");
    Console.WriteLine($"Tried letters: {game.TriedLetters}");
}
if(game.GameStatus==GameStatus.Lost)
{
    Console.WriteLine("You are hanged");
    Console.WriteLine($"The word was: {game.Word}");
}
else if(game.GameStatus==GameStatus.Won)
    Console.WriteLine("You won!");


