using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ballOfTruth
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        void onButtonClicked(object sender, EventArgs e)
        {
            trueOrFalse_Label.Text = rand.Next()%2==0?"Правда":"Ложь";
        }

        void onButtonPressed(object sender, EventArgs e)
        {
            button.Source = "Component1Clicked.png";
        }
        void onButtonReleased(object sender, EventArgs e)
        {
            button.Source = "Component1.png";
        }
    }
}
