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
	public partial class QuotePage : ContentPage
	{
		public QuotePage ()
		{
			InitializeComponent ();

            slider.Value = 16;
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {            
            string[] quotes = { "hello", "what", "yo" };
            Quote.Text = quotes[0];
        }
    }
}