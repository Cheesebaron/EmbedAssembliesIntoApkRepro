using Shared;
using Shared.Resources;

namespace AndroidApp1;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);

        var languages = new Languages();
        var textView = FindViewById<TextView>(Resource.Id.greeting);
        textView.Text = Strings.Greeting;
        var toggle = FindViewById<Button>(Resource.Id.toggle);
        toggle.Click += delegate
        {
            languages.ToggleLanguage();
            textView.Text = Strings.Greeting;
        };
    }
}
