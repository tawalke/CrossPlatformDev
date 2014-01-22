using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using TipCalc.CrossPlat.Core.Services;


namespace TipCalc.CrossPlat.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.RegisterType<ICalculation, Calculation>();
            RegisterAppStart<ViewModels.TipViewModel>();
        }
    }
}