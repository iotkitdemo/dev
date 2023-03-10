using System;

namespace Calculator.App.Services;

    public class AdditionService : ICalculatorService
    {
        public int Operate(int left, int right)
        {
            // need to check with Dave why we had this???
            //if (right == 17)
            //{
            //   right = right * 2;
            //}
            return left + right;
        }
    }