using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Cirrious.MvvmCross.WindowsPhone.Views;
using TipCalc.CrossPlat.Core.ViewModels;

namespace TipCalc.CrossPlat.WinPhone.Views
{
    //public partial class TipView : PhoneApplicationPage
    public partial class TipView : MvxPhonePage
    {
        public new TipViewModel ViewModel 
        {
            get { return (TipViewModel)base.ViewModel;}
            set {base.ViewModel = value;}
 
        }

        public TipView()
        {
            InitializeComponent();
        }

        
    }
}