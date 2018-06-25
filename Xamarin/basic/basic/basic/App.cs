using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace basic
{
    public class App : Application
    {
        //public App ()
        //{
        //	// The root page of your application
        //	MainPage = new ContentPage {
        //		Content = new StackLayout {
        //			VerticalOptions = LayoutOptions.Center,
        //			Children = {
        //				new Label {
        //					HorizontalTextAlignment = TextAlignment.Center,
        //					Text = "Welcome to Xamarin Forms!"
        //				}
        //			}
        //		}
        //	};
        //}
        public App()
        {
            // The root page of your application
            var layout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
            new Label {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Welcome to Xamarin Forms!"
            }
        }
            };

            MainPage = new ContentPage
            {
                Content = layout
            };

            Button button = new Button
            {
                Text = "Click Me"
            };

            button.Clicked += async (s, e) =>
            {
                await MainPage.DisplayAlert("Alert", "You clicked me", "OK");
            };

            layout.Children.Add(button);
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
