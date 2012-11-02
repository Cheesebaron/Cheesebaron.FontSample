using Android.App;
using Android.OS;

namespace Cheesebaron.FontSample
{
    [Activity(Label = "Font Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class SampleActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

