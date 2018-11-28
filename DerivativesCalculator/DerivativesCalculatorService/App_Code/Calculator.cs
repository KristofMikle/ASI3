using System;

namespace DerivativesCalculatorService
{
    public class Calculator : IDerivativesCalculator
    {
        #region IDerivativesCalculator Members
        public decimal CalculateDerivative(int days, string[] symbols, string[] functions)
        {
            return DateTime.Now.Millisecond;
        }
        #endregion
    }
}