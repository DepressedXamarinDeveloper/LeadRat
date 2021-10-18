using MvvmCross.IoC;
using MvvmCross.ViewModels;
using LeadRat.Core.ViewModels.Main;

namespace LeadRat.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
