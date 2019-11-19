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
        public static WeakReference wr;

        public ImagePage()
        {
            wr = new WeakReference(this);
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ImageView.Source = null;
        }

    }
}
