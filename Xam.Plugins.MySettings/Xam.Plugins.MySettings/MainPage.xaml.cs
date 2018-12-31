using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xam.Plugins.MySettings
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.label.Text= Settings.MyValue??"Null";
            if (Settings.MyValue == null)
                Settings.MyValue = "Test Value";
        }
    }
}
