using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GalleryRenderer
{
    public class GalleryView : ContentView
    {

        public static readonly BindableProperty NameProperty = BindableProperty.Create(
  propertyName: "Camera",
  returnType: typeof(string),
  declaringType: typeof(GalleryView),
  defaultValue: "this is my name");




        public string Name
        {
            get { return (string) GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

    }
}
