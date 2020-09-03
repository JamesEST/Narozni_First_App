using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Narozni_First_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ValgusFoor : ContentPage
    {
        public ValgusFoor()
        {
            InitializeComponent();
        }
        int click = 0;
        private void BtnOn_Clicked(object sender, EventArgs e)
        {
            click++;
            Random rnd = new Random();
            click = rnd.Next(1, 4);
            if (click == 1)
            {
                RedFrame.BackgroundColor = Color.Red;
                YellowFrame.BackgroundColor = Color.Gray;
                GreenFrame.BackgroundColor = Color.Gray;

            }
             
            else if (click == 2)
            {
                YellowFrame.BackgroundColor = Color.Yellow;
                RedFrame.BackgroundColor = Color.Gray;
                GreenFrame.BackgroundColor = Color.Gray;

            }
           
            else if (click == 3)
            {
                GreenFrame.BackgroundColor = Color.Green;
                YellowFrame.BackgroundColor = Color.Gray;
                RedFrame.BackgroundColor = Color.Gray;

            }

        }

        private void BtnOff_Clicked(object sender, EventArgs e)
        {
            RedFrame.BackgroundColor = Color.Gray;
            YellowFrame.BackgroundColor = Color.Gray;
            GreenFrame.BackgroundColor = Color.Gray;

        }
    }
}