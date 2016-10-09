using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace GalleryRenderer.Droid
{
    [Activity(Label = "GalleryRenderer", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            //FrameLayout ContentView = new FrameLayout(this);
            //Gallery gallery = new Gallery(this);
            //gallery.Adapter = new ImageAdapter(this);
            //ContentView.AddView(gallery);
            //SetContentView(ContentView);
            LoadApplication(new App());
        }
    }
}

