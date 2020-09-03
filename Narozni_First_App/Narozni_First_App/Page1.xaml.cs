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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            //InitializeComponent();

            Label punane = new Label()
            {
                Text = "Punane", TextColor = Color.White, FontSize = 10, FontAttributes=FontAttributes.Bold
            };
            Frame pun = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = punane,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            Label kollane = new Label()
            {
                Text = "kollane",
                TextColor = Color.Yellow,
                FontSize = 10,
                FontAttributes = FontAttributes.Bold
            };
            Frame yew = new Frame()
            {
                BackgroundColor = Color.Yellow,
                Content = kollane,
                Padding = 50,
                CornerRadius = 90,
                HorizontalOptions = LayoutOptions.Center
            };

            Label roheline = new Label()
            {
                Text = "Roheline",
                TextColor = Color.Green,
                FontSize = 10,
                FontAttributes = FontAttributes.Bold
            };
            Frame gre = new Frame()
            {
                BackgroundColor = Color.Green,
                Content = roheline,
                Padding = 50,
                CornerRadius = 90,
                HorizontalOptions = LayoutOptions.Center
            };
            Button btn1 = new Button()
            {
                HorizontalOptions = LayoutOptions.Start,
                Text = "ON",
                
            };
            Button btn2 = new Button()
            {
                HorizontalOptions = LayoutOptions.End,
                Text = "OFF",

            };
            StackLayout stackLayout2 = new StackLayout()
            {
                Children = { btn1, btn2 }
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = {pun, yew, gre, stackLayout2}
                
            };
            stackLayout2.Orientation = StackOrientation.Horizontal;
            stackLayout2.Margin = new Thickness(90, 0, 0, 0);

            Content = stackLayout;
         
        }
    }
}