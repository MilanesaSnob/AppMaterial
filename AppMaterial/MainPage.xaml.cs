using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMaterial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonOnClicked (object sender, EventArgs e)
        {
            string text = MainEntry.Text;
            MainLabel.Text = "Hello " + text;
        }
    }
}
