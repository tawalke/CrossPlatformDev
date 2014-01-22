using Android.App;
using Cirrious.MvvmCross.Droid.Views;


namespace TipCalc.CrossPlat.Droid
{
    [Activity(Label = "Utility App", MainLauncher = true)]
    public class TipView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.ViewTip);
        }
    }
}