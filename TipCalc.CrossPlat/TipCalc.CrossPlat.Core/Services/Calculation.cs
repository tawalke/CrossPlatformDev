using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TipCalc.CrossPlat.Core.Services
{
    class Calculation : ICalculation
    {
        public double TipAmount(double subTotal, int tipPercent) 
        {
            return subTotal * (tipPercent / 100.0);
        }

        public double TotalAmount(double billAmount, double tipAmount)
        {
            return billAmount + tipAmount;
        }
    }
}
