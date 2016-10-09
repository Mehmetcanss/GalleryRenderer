using Android.Content;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GalleryRenderer
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            GalleryView gallery = new GalleryView();
            gallery.Name = "gallery";
            gallery.HorizontalOptions = LayoutOptions.FillAndExpand;
            gallery.VerticalOptions = LayoutOptions.FillAndExpand;
            Grid grid = new Grid
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                ColumnDefinitions =
                {
                    new ColumnDefinition
                    {
                        Width = new GridLength(1, GridUnitType.Star)
                    },
                    new ColumnDefinition { Width = new GridLength(5, GridUnitType.Star) },
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star) }
                }
            };
            grid.Children.Add(gallery, 1, 0);
            MainPage = new ContentPage
            {
                Content = 
                
                    //VerticalOptions = LayoutOptions.Center,
                    //Children = {
                    //    new Label {
                    //        HorizontalTextAlignment = TextAlignment.Center,
                    //        Text = "Welcome to Xamarin Forms!"
                    //    }
                    //}
                    new ContentView
                    {
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Content = grid
                    }
              
                
            };
            

            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
