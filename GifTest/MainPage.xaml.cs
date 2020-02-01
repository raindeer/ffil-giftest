using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFImageLoading.Cache;
using FFImageLoading.Forms;
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
                var status = "Is the page object still alive? " + ImagePage.wr.IsAlive;
                Console.WriteLine(status);
                StatusLabel.Text = status;
            }
            else
            {
                var status = "Open ImagePage once first";
                Console.WriteLine(status);
                StatusLabel.Text = status;
            }
        }

        private void ClearCacheButton_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("Invalidating cached gif");
            CachedImage.InvalidateCache(ImagePage.gifUrl, CacheType.All, true);
        }
    }
}
