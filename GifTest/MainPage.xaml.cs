using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GifTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void OpenPageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ImagePage());
        }

        private void CheckAliveButton_Clicked(object sender, EventArgs e)
        {
            if (ImagePage.wr != null)
            { 
                GC.Collect();
                Console.WriteLine("Is the page object still alive? " + ImagePage.wr.IsAlive);
            }
            else
            {
                Console.WriteLine("Open ImagePage once first");
            }
        }
    }
}
