using System;

using Xamarin.Forms;

namespace WeatherCities.Views
{
    public class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

