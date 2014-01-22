using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirrious.MvvmCross.ViewModels;
using TipCalc.CrossPlat.Core.Services;
using TipCalc.CrossPlat.Core.Models;

namespace TipCalc.CrossPlat.Core.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        private readonly ICalculation _calculation;

        
        private Tip _tip;
        
        //Constructor
        public TipViewModel(ICalculation calculation) 
        {
            _calculation = calculation;
            _tip = new Tip();
        }

        //Properties
        public double TipTotal 
        {
            get { return _tip.Total; }
            protected set 
                {
                    _tip.Total = value;
                    RaisePropertyChanged<double>(() => TipTotal);
                    //RaisePropertyChanged("TipTotal");
                }
        }

        public double BillTotal
        {
            get { return _tip.BillTotal;}
            protected set 
                {
                    _tip.BillTotal = value;
                    RaisePropertyChanged<double>(() => BillTotal);
                    //RaisePropertyChanged(()=>BillTotal);
                }
        }

        public double BillSubTotal
        {
            get { return _tip.SubTotal; }
            set {
                    _tip.SubTotal = value;
                    RaisePropertyChanged<double>(() => BillSubTotal);
                    //RaisePropertyChanged("BillSubTotal");
                    Recalculate();
                }          
                
        }

        public int TipPercent 
        {
            get { return _tip.TipPercent; }
            set { 
                    _tip.TipPercent = value;
                    RaisePropertyChanged<int>(() => TipPercent);
                    //RaisePropertyChanged("TipPercent");
                    Recalculate();
                }
        }

        public void CalculateTip(double amount, int percentage) 
        {
            _tip.SubTotal = amount;
            _tip.TipPercent = percentage;
            Recalculate();
        }
        public override void Start()
        {
            CalculateTip(100, 10);
            base.Start();
        }

       
        private void Recalculate() 
        {
            this.TipTotal = _calculation.TipAmount(_tip.SubTotal, _tip.TipPercent);
            this.BillTotal = _calculation.TotalAmount(_tip.SubTotal, _tip.Total);
        }
        
    }
}
