using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace sushi3
{
    public class App : Application
    {
        public App()
        {
            MainPage = new MyPage();
        }

        class MyPage : ContentPage
        {
            public MyPage()
            {
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

                var source = new HtmlWebViewSource
                {
                    Html = "<marquee><font size='5'>🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　🍣　　</font></marquee>"
                };

                Content = new WebView
                {
                    Source = source
                };
            }
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
