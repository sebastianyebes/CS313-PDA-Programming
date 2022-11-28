using CS313_PDA_Programming.Interfaces;

namespace CS313_PDA_Programming.Algorithms
{
    /// <summary>
    /// Solves the input wether if the input is accepted as a palindrome or not
    /// </summary>
    internal class PalindromeAlgo : IAlgorithm
    {
        public void implement(string input)
        {
            Stack<char> stack = new Stack<char>();
            int length = input.Length;

            Console.WriteLine("\nProcess:");

            if (length == 0)
            {
                throw new Exception("Input is null");
            }
            // if |input| is even, then push a & b, if |input| is already in the half part, then pop a on a & pop b on b
            else if (length % 2 == 0) 
            {
                for (int i = 0; i < length; i++)
                {
                    if (i < length / 2)
                    {
                        Console.WriteLine("Pushed: " + input[i]);
                        stack.Push(input[i]);
                        continue;
                    }
                    
                    if(stack.Peek() == input[i])
                    {
                        Console.WriteLine("Popped: " + input[i]);
                        stack.Pop();
                    }
                }
            }
            // if |input| is odd, then push a & b, if |input| is already in the middle, then skip wether its a or b, then after the middle, you pop a on a & pop b on b
            else if (length % 2 != 0) 
            {
                for (int i = 0; i < length; i++)
                {
                    if (i < length / 2)
                    {
                        Console.WriteLine("Pushed: " + input[i]);
                        stack.Push(input[i]);
                        continue;
                    }
                    else if(i == length / 2)
                    {
                        Console.WriteLine("Read and Skipped: " + input[i]);
                        continue;
                    }

                    if (stack.Peek() == input[i])
                    {
                        Console.WriteLine("Popped: " + input[i]);
                        stack.Pop();
                    }
                }
            }

            // if the stack is empty, then it means the input is a palindrome
            if(stack.Count == 0)
            {
                Console.WriteLine("\nInput is Accepted!");
            }
            else
            {
                Console.WriteLine("\nInput is not Accepted!");
            }
        }
    }
}
