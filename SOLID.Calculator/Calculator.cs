﻿using System;
using System.Collections.Generic;

namespace SOLID.Math
{
    public class Calculator: ICalculator
    {
        private double result;

        public ICalculator Input(double initialValue)
        {
            result = initialValue;
            Log("Initial value: {0}", initialValue);
            return this;
        }

        public ICalculator Input(string @operator, double operand)
        {
            if (@operator == null)
            {
                throw new ArgumentNullException(nameof(@operator));
            }

            Log("Applying operation {0}. Value={1}", @operator, operand);
            switch (@operator)
            {
                case "+":
                    result += operand;
                    break;
                case "-":
                    result -= operand;
                    break;
                case "*":
                    result *= operand;
                    break;
                case "/":
                    result /= operand;
                    break;
                default:
                    throw new NotSupportedException($"Operator not supported: {@operator}");
            }
            Log("Applying operation {0}. Value={1}", @operator, operand);
            return this;
        }

        public double Result()
        {
            return result;
        }

        private void Log(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }
    }
}
