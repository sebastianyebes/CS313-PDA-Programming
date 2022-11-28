using CS313_PDA_Programming.Interfaces;

namespace CS313_PDA_Programming.Algorithms
{
    internal class BalancingParenthesesAlgo : IAlgorithm
    {
        /// <summary>
        /// Solves the input wether if the input is balanced or not
        /// </summary>
        /// <param name="input"> the string to be solved </param>
        public void implement(string input)
        {
            Stack<char> stack = new Stack<char>();
            int length = input.Length;

            for(int i = 0; i < length; i++)
            {
                if(input[i] == '(' || input[i] == '{' || input[i] == '['){ // if input[i] is a starting bracket, then push to stack
                    Console.WriteLine("Pushed: " + input[i]);
                    stack.Push(input[i]);
                    continue;
                }

                if(input[i] == ')' && stack.Peek() == '(' || // if input[i] is a closing bracket, and it matches its pair, then pop from stack
                   input[i] == ']' && stack.Peek() == '[' ||
                   input[i] == '}' && stack.Peek() == '{')
                {
                    Console.WriteLine("Popped: " + input[i]);
                    stack.Pop();
                }
            }

            // if the stack is empty, then it means the input is balanced
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
