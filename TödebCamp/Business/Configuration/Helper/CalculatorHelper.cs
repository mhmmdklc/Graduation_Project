﻿
namespace Businesss.Configuration.Helper
{
    public static class CalculatorHelper
    {
        public static decimal CalculateCommission(decimal price)
        {
            var commision = price * (decimal)0.02;
            return commision;
        }

        public static decimal CalculateVAT(decimal price, float rate)
        {
            var vat = (price * (decimal)rate) / 100;
            return vat;
        }
    }
}