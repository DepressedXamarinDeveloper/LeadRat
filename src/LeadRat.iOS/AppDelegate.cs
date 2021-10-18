using Foundation;
using MvvmCross.Platforms.Ios.Core;
using LeadRat.Core;

namespace LeadRat.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}
