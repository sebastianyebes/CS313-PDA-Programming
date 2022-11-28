using CS313_PDA_Programming.Interfaces;

namespace CS313_PDA_Programming.Algorithms
{
    internal class BalancingParenthesesAlgo : IAlgorithm
    {
        public void implement(string input)
        {
            Stack<char> stack = new Stack<char>();
            int length = input.Length;

            for(int i = 0; i < length; i++)
            {
                if(input[i] == '(' || input[i] == '{' || input[i] == '['){
                    Console.WriteLine("Pushed: " + input[i]);
                    stack.Push(input[i]);
                    continue;
                }

                if(input[i] == ')' && stack.Peek() == '(' || 
                   input[i] == ']' && stack.Peek() == '[' ||
                   input[i] == '}' && stack.Peek() == '{')
                {
                    Console.WriteLine("Popped: " + input[i]);
                    stack.Pop();
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("\nInput is Balanced, therefore it is Accepted!");
            }
            else
            {
                Console.WriteLine("\nInput is Unbalanced, therefore it is not Accepted!");
            }
        }
    }
}
