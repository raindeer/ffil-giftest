using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GifTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public const string gifUrl = "https://media1.giphy.com/media/xUPGcfbMG6a2k2z57O/source.gif";
        public const string jpgUrl = "https://i0.wp.com/metro.co.uk/wp-content/uploads/2019/10/PRI_89978732.jpg";

        public static WeakReference wr;

        public ImagePage()
        {
            wr = new WeakReference(this);
            InitializeComponent();
            ImageView.Source = gifUrl;
            //ImageView.Source = jpgUrl; // A static image doesnt keep the page alive
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

    }
}
