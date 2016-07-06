using Android.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;

namespace try1
{
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            this.Title = "Sample Weather App";
            Log.Info("MIKE", "Just set the title");



            getWeatherBtn.Clicked += GetWeatherBtn_Clicked;

            //Set the default binding to a default object for now
        
            this.BindingContext = new Weather();

        }

        private async void GetWeatherBtn_Clicked(object sender, EventArgs e)
        {
            Log.Info("MIKE", "A1");
            Weather weather = await Core.GetWeather("37211");
            Log.Info("MIKE", "A2");
            getWeatherBtn.Text = weather.Title;

        }

    }
}
