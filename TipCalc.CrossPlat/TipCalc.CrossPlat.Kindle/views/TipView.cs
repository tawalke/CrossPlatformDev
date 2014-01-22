using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace TipCalc.CrossPlat.Kindle.views
{
    [Activity(Label = "Tip View")]
    public class TipView : MvxActivity
    {

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.TipView);
        }

       //protected override void OnCreate(Bundle bundle)
       // {
       //     base.OnCreate(bundle);
               
       //     // Create your application here


       // }
    }
}