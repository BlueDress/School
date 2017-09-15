﻿namespace Dependency_Inversion
{
    public class PrimitiveCalculator
    {
        private IStrategy strategy;

        public PrimitiveCalculator()
        {
            this.strategy = new AdditionStrategy();
        }

        public void changeStrategy(char @operator)
        {
            switch (@operator)
            {
                case '+':
                    this.strategy = new AdditionStrategy();
                    break;
                case '-':
                    this.strategy = new SubtractionStrategy();
                    break;
                case '*':
                    this.strategy = new MultiplyStrategy();
                    break;
                case '/':
                    this.strategy = new DivideStrategy();
                    break;
            }
        }

        public int performCalculation(int firstOperand, int secondOperand)
        {
            return this.strategy.Calculate(firstOperand, secondOperand);
        }
    }
}
