using Android.App;
using Android.Content;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;
using TipCalc.CrossPlat.Core;

namespace TipCalc.CrossPlat.Droid
{
    public class Setup: MvxAndroidSetup
    {
        public Setup(Context applicationContext)
            : base(applicationContext)
        { 
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        //protected override IMvxNavigationSerializer CreateNavigationSerializer()
        //{
        //    Cirrious.MvvmCross.Plugins.Json.PluginLoader.Instance.EnsureLoaded();
        //    return new MvxJsonNavigationSerializer();
        //    //return base.CreateNavigationSerializer();
        //}
    }
}