using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TipCalc.CrossPlat.Core.Services
{
    public interface ICalculation
    {

        double TipAmount(double subTotal, int tipPercent);
        double TotalAmount(double billAmount, double tipAmount);
    }
}
