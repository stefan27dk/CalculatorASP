using CalculatorASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorASP.Services
{
    public class CalculatorService : ICalculatorService
    {

        public int Calculate(int input1, int input2, string op)
        {
            int result = 0;
            // Add
            if (op == "add")
            {
                result = input1 + input2;
            }

            // Minus
            else if (op == "min")
            {
                result = input1 - input2;
            }


            // Subtract
            else if (op == "sub")
            {
                result = input1 * input2;
            }


            // Divide
            else
            {
                result = input1 / input2;
            }

            return result;
        }
    }
}
