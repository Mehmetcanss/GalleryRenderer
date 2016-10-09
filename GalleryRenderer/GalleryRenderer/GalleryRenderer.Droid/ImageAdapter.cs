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
using Java.Lang;

namespace GalleryRenderer.Droid
{
    class ImageAdapter : BaseAdapter
    {
        Context context;
        public ImageView[] ImageViews;

        public ImageAdapter(Context c)
        {
            context = c;
            ImageViews = new ImageView[thumbIds.Length];
            for(int i = 0; i < thumbIds.Length; i++)
            {
                ImageViews[i] = new ImageView(context);
                ImageViews[i].SetImageResource(thumbIds[i]);
                ImageViews[i].LayoutParameters = new Gallery.LayoutParams(300, 200);
                ImageViews[i].SetScaleType(ImageView.ScaleType.FitXy);

            }
        }

        public override int Count { get { return thumbIds.Length; } }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        // create a new ImageView for each item referenced by the Adapter
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            return ImageViews[position];
        }

        // references to our images
        int[] thumbIds = {
            Resource.Drawable.sample_1,
            Resource.Drawable.sample_2,
            Resource.Drawable.sample_3,
            Resource.Drawable.sample_4,
            Resource.Drawable.sample_5,
            Resource.Drawable.sample_6,
            Resource.Drawable.sample_7
     };
    }
}