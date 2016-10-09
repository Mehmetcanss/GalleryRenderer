using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GalleryRenderer.Droid
{
    class AndGallery : FrameLayout, AdapterView.IOnItemSelectedListener
    {

        private Context context;
        private Gallery gallery;

        public AndGallery(Context c, ImageAdapter a) : base(c)
        {
            this.context = c;
            gallery = new Gallery(context);
            gallery.Adapter = a;
            gallery.OnItemSelectedListener = this;
            FrameLayout.LayoutParams paramsForGallery = new FrameLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent);
            paramsForGallery.Gravity = GravityFlags.CenterVertical;
            gallery.LayoutParameters = paramsForGallery;
            gallery.SetBackgroundColor(Android.Graphics.Color.Transparent);
            this.AddView(gallery);

        }

        public void OnItemSelected(AdapterView parent, View view, int position, long id)
        {

            Gallery parentGallery = parent as Gallery;
            ImageAdapter adap = parentGallery.Adapter as ImageAdapter;
            foreach(ImageView img in adap.ImageViews)
            {
                img.ScaleX = 1;
                img.ScaleY = 1;
            }

            ((ImageView)view).ScaleX = 2;
            ((ImageView)view).ScaleY = 2;
 
        }

        public void OnNothingSelected(AdapterView parent)
        {

        }
    }
}