using CS313_PDA_Programming.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS313_PDA_Programming.Algorithms
{
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
            else if(length % 2 == 0)
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
            else if(length % 2 != 0)
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
