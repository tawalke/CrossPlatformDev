using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Cirrious.MvvmCross.ViewModels;

namespace TipCalc.CrossPlat.Core.Models
{
    public class Tip : MvxNotifyPropertyChanged
    {
        private double _subTotal;
        private int _tipPercent;
        private double _tipTotal;
        private double _billTotal;

        public double SubTotal
        {
            get { return _subTotal; }
            set {   
                    _subTotal = value;
                    //RaisePropertyChanged(() => SubTotal);
                    RaisePropertyChanged("SubTotal");
                
                }
        }

        public int TipPercent 
        {
            get { return _tipPercent; }
            set { 
                    _tipPercent = value;
                    //RaisePropertyChanged(() => TipPercent);
                    RaisePropertyChanged("TipPercent");

                }
        }

        public double Total 
        {
            get { return _tipTotal; }
            set {
                    _tipTotal = value;
                    //RaisePropertyChanged(() => Total);
                RaisePropertyChanged("Total");
                }
        }

        public double BillTotal
        {
            get { return _billTotal; }
            set {
                    _billTotal = value;
                    //RaisePropertyChanged(() => BillTotal);
                    RaisePropertyChanged("BillTotal");
                }
        }

    }
}
