// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace TipCalc.CrossPlat.iOS
{
	[Register ("TipViewUI")]
	partial class TipViewUI
	{
		[Outlet]
		MonoTouch.UIKit.UILabel BillSubTotalLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField BillSubTotalTextField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TipCalcLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TipPercentLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISlider TipPercentSlider { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TipPercentValue { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TipTotalLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TipTotalValue { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TotalAmountLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TotalAmountValue { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TipCalcLabel != null) {
				TipCalcLabel.Dispose ();
				TipCalcLabel = null;
			}

			if (BillSubTotalLabel != null) {
				BillSubTotalLabel.Dispose ();
				BillSubTotalLabel = null;
			}

			if (BillSubTotalTextField != null) {
				BillSubTotalTextField.Dispose ();
				BillSubTotalTextField = null;
			}

			if (TipPercentLabel != null) {
				TipPercentLabel.Dispose ();
				TipPercentLabel = null;
			}

			if (TipPercentSlider != null) {
				TipPercentSlider.Dispose ();
				TipPercentSlider = null;
			}

			if (TipPercentValue != null) {
				TipPercentValue.Dispose ();
				TipPercentValue = null;
			}

			if (TipTotalLabel != null) {
				TipTotalLabel.Dispose ();
				TipTotalLabel = null;
			}

			if (TipTotalValue != null) {
				TipTotalValue.Dispose ();
				TipTotalValue = null;
			}

			if (TotalAmountLabel != null) {
				TotalAmountLabel.Dispose ();
				TotalAmountLabel = null;
			}

			if (TotalAmountValue != null) {
				TotalAmountValue.Dispose ();
				TotalAmountValue = null;
			}
		}
	}
}
