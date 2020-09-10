using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Narozni_First_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private Random rnd = new Random();
        Label punane, kollane, roheline, warning;
        Frame pun, yew, gre;
        Button btn1, btn2, btn3;
        int click = 0;
        int kklik = 0;
        bool status;
        public Page1()
        {
            //InitializeComponent();

            punane = new Label()
            {
                
                TextColor = Color.White,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold
            };
            pun = new Frame()
            {
                HeightRequest = 40,
                WidthRequest = 90,
                BackgroundColor = Color.Red,
                Content = punane,
                CornerRadius = 90,
                Padding = 80,
                HorizontalOptions = LayoutOptions.Center
            };
            kollane = new Label()
            {
                
                TextColor = Color.White,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold
            };
            yew = new Frame()
            {
                HeightRequest = 40,
                WidthRequest = 90,
                BackgroundColor = Color.Yellow,
                Content = kollane,
                Padding = 80,
                CornerRadius = 90,
                HorizontalOptions = LayoutOptions.Center
            };

            roheline = new Label()
            {
               
                TextColor = Color.White,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold
            };
            gre = new Frame()
            {
                HeightRequest = 40,
                WidthRequest = 90,
                BackgroundColor = Color.Green,
                Content = roheline,
                Padding = 80,
                CornerRadius = 90,
                HorizontalOptions = LayoutOptions.Center
            };
            warning = new Label()
            {
                Text = "",

            };
            btn1 = new Button()
            {
                HorizontalOptions = LayoutOptions.Start,
                Text = "ON",

            };
            btn2 = new Button()
            {
                HorizontalOptions = LayoutOptions.End,
                Text = "OFF",

            };
            btn3 = new Button()
            {
                HorizontalOptions = LayoutOptions.End,
                Text = "Auto",
                

        };
            StackLayout stackLayout2 = new StackLayout()
            {
                Children = { btn1, btn2, btn3 }
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { pun, yew, gre, stackLayout2, warning}

            };
            stackLayout2.Orientation = StackOrientation.Horizontal;
            stackLayout2.Margin = new Thickness(90, 0, 0, 0);

            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;


            Content = stackLayout;

            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            pun.GestureRecognizers.Add(tap);
            yew.GestureRecognizers.Add(tap);
            gre.GestureRecognizers.Add(tap);

        }

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            if (status == true)
            {
                for (int i = 0; i < 10; i++)
                {

                    await Task.Run(() => Thread.Sleep(1000));
                    Color randomColor2 = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    pun.BackgroundColor = randomColor2;
                    await Task.Run(() => Thread.Sleep(1000));
                    Color randomColor3 = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    yew.BackgroundColor = randomColor3;
                    await Task.Run(() => Thread.Sleep(1000));
                    Color randomColor4 = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    gre.BackgroundColor = randomColor4;

                }
            }
            else if (status == false)
            {
                warning.Text = "У тебя светофор выключен";
            }
            


        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            kklik++;
            

            Frame fr = sender as Frame;
            if (status == true)
            {
                
                if (kklik %2 == 0)
                {
                    if (fr == pun) { punane.Text = "Остановить и жди!"; }



                    else if (fr == yew) { kollane.Text = "Жди"; }
                    else if (fr == gre) { roheline.Text = "Можешь идти"; }
                }
                else
                {
                    punane.Text = "Красный";
                    kollane.Text = "Желтый"; 
                    roheline.Text = "Зеленый";

                }
            }
            else if (status == false)
            {
                warning.Text = "У тебя светофор выключен";
            }
            
            
         }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            status = false;
            pun.BackgroundColor = Color.Gray;
            yew.BackgroundColor = Color.Gray;
            gre.BackgroundColor = Color.Gray;
            
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            punane.Text = "Красный";
            kollane.Text = "Желтый";
            roheline.Text = "Зеленый";
            warning.Text = "";
            click++;
            status = true;
            Random rnd = new Random();
            click = rnd.Next(1, 4);
            if (click == 1)
            {
                
                pun.BackgroundColor = Color.Red;
                yew.BackgroundColor = Color.Gray;
                gre.BackgroundColor = Color.Gray;

            }

            else if (click == 2)
            {
                yew.BackgroundColor = Color.Yellow;
                pun.BackgroundColor = Color.Gray;
                gre.BackgroundColor = Color.Gray;

            }

            else if (click == 3)
            {
                gre.BackgroundColor = Color.Green;
                yew.BackgroundColor = Color.Gray;
                pun.BackgroundColor = Color.Gray;

            }
        }
    }
}