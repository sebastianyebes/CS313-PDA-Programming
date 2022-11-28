using CS313_PDA_Programming;
using CS313_PDA_Programming.Factories;
using CS313_PDA_Programming.Interfaces;

class Program
{
    public static void Main()
    {
        Console.Write("Programs:\n1 - Palindrome\n2 - Balancing Parantheses\n\nAnswer: ");
        var input = Console.ReadLine();
        int program = Convert.ToInt32(input);

        Console.Clear();
        if (program == 1)
        {
            Console.WriteLine("PALINDROME\n");
        }
        else if (program == 2)
        {
            Console.WriteLine("BALANCING PARANTHESES\n");
        }
        else
        {
            throw new Exception("Invalid Input");
        }

        Console.Write("Input: ");
        input = Console.ReadLine();
        IAlgorithm algorithm = PDAFactory.GetAlgorithm(program);
        algorithm.implement(input);
    }
}