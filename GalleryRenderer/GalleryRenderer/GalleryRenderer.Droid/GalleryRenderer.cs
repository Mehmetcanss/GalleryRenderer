using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using GalleryRenderer;

[assembly: ExportRenderer(typeof(GalleryView), typeof(GalleryRenderer.Droid.GalleryRenderer))]
namespace GalleryRenderer.Droid
{
    class GalleryRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);
            if (this.Control == null)
            {
                FrameLayout lay = new FrameLayout(Android.App.Application.Context);
                SetNativeControl(lay);
                AndGallery gallery = new AndGallery(Android.App.Application.Context, new ImageAdapter(Android.App.Application.Context));
                
              
                

                ((ViewGroup)this.Control).AddView(gallery);


            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (this.Control != null)
            {




            }
        }

    }
}