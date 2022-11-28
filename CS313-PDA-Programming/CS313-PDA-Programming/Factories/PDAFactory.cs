using CS313_PDA_Programming.Algorithms;
using CS313_PDA_Programming.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS313_PDA_Programming.Factories
{
    public class PDAFactory
    {
        public static IAlgorithm GetAlgorithm(int input)
        {
            switch (input)
            {
                case 1:
                    return new PalindromeAlgo();
                case 2:
                    return new BalancingParenthesesAlgo();
                default:
                    throw new Exception("Invalid Input..");
            }
        }
    }
}
