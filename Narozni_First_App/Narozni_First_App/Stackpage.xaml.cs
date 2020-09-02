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
    public partial class Stackpage : ContentPage
    {
        public Stackpage()
        {
            InitializeComponent();
        }
        int clik = 0;
        private void btn_Clicked(object sender, EventArgs e)
        {
            clik++;
            btn.Text = clik.ToString();
            if(clik % 5 ==0)
            {
                lbl.Text = "";
            }
            else
            {
                lbl.Text = "Test New Casino";
            }
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            clik = 0;
            btn.Text = clik.ToString();
        }
    }
}