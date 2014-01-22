using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
//using TipCalc.CrossPlat.Core;
using TipCalc.CrossPlat.Core.ViewModels;

namespace TipCalc.CrossPlat.iOS
{
	public partial class TipViewUI : MvxViewController
	{
		public TipViewUI () : base ("TipViewUI", null)
		{
		}

		public new TipViewModel ViewModel
		{

			get { return (TipViewModel) base.ViewModel; }
			set { base.ViewModel = value; }
		}
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

			this.CreateBinding (this.BillSubTotalTextField).To((TipViewModel vm) => vm.BillSubTotal).Apply();
			this.CreateBinding (this.TipPercentSlider).To((TipViewModel vm) => vm.TipPercent).Apply();
			this.CreateBinding (this.TipPercentValue).To((TipViewModel vm) => vm.TipPercent).Apply();
			this.CreateBinding (this.TipTotalValue).To((TipViewModel vm) => vm.TipTotal).Apply();
			this.CreateBinding (this.TotalAmountValue).To((TipViewModel vm) => vm.BillTotal).Apply();
		}
	}
}

