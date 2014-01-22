using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Phone.Controls;
using Cirrious.MvvmCross.WindowsPhone.Platform;
using Cirrious.MvvmCross.ViewModels;


namespace TipCalc.CrossPlat.WinPhone
{
    public class Setup: MvxPhoneSetup
    {
        public Setup(PhoneApplicationFrame rootframe) 
            : base(rootframe) 
        { 
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
            //throw new NotImplementedException();
        }

        protected override IMvxNavigationSerializer CreateNavigationSerializer()
        {
            //return base.CreateNavigationSerializer();
            Cirrious.MvvmCross.Plugins.Json.PluginLoader.Instance.EnsureLoaded();
            return new MvxJsonNavigationSerializer();
        }

    }
}
