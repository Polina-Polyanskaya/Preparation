using System.Text;

namespace TicTacToe
{
    class Program
    {
        static TicTacToe t = new TicTacToe();
        static void Main(string[] args)
        {
            Console.WriteLine(GetPrintableState());
            while(t.GetWinner() == Winner.GameIsUnfinished)
            {
                t.MakeMove(int.Parse(Console.ReadLine()));
                Console.WriteLine();
                Console.WriteLine(GetPrintableState());
            }
            Console.WriteLine($"Result {t.GetWinner()}");
        }

        static string GetPrintableState()
        {
            var sb = new StringBuilder();
            for(int i=1;i<=7;i+=3)
            {
                sb.AppendLine("     |     |     |")
                    .AppendLine($"  {GetPrintableChar(i)}  |  {GetPrintableChar(i + 1)}  |  {GetPrintableChar(i + 2)}  ")
                  .AppendLine("_____|_____|_____|");
            }
            return sb.ToString();  
        }

        static string GetPrintableChar(int index)
        {
            State state = t.GetState(index);
            if (state == State.Unset)
                return index.ToString();
            return state == State.Cross ? "X" : "O";
        }
    }
}
