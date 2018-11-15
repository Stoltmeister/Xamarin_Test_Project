using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Test_Project
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
        public GreetPage()
        {
            InitializeComponent();

            slider.Value = 0.5;
            

            //switch(Device.RuntimePlatform)
            //{
            //    case "iOS":
            //        Padding = new Thickness(0, 20, 0, 0);
            //        break;
            //    case "Android":
            //        Padding = new Thickness(10, 20, 0, 0);
            //        break;
            //}

		}
        
    }
}