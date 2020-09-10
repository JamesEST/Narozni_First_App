using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Narozni_First_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        private Random rnd = new Random();
        Slider red, greenn, bluee;
        Stepper redd;
        Label color;
        Button btn1;
        int NewValue;

        public Page2()
        {
            red = new Slider()
            {
                Maximum = 255,
                Minimum = 0,
                Value = 0,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 90,
                WidthRequest = 20,

            };
            redd = new Stepper()
            {
                Maximum = 255,
                Minimum = 0,
                Value = 0,
                HorizontalOptions = LayoutOptions.End,
                HeightRequest = 90,
                WidthRequest = 20,

            };
            greenn = new Slider()
            {
                Maximum = 255,
                Minimum = 0,
                Value = 0,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 90,
                WidthRequest = 20,
            };
            bluee = new Slider()
            {
                Maximum = 255,
                Minimum = 0,
                Value = 0,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 90,
            };

            btn1 = new Button()
            {
                HorizontalOptions = LayoutOptions.Start,
                Text = "RandomColor",
            };

                color = new Label()
            {
                Text = "1"
            };


            StackLayout stackLayout = new StackLayout()
            {
                Children = { red, greenn, bluee, color, btn1 }
            };
            btn1.Clicked += Btn1_Clicked;
            red.ValueChanged += Red_ValueChanged;
            greenn.ValueChanged += Greenn_ValueChanged;
            bluee.ValueChanged += Bluee_ValueChanged;

            Content = stackLayout;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            randomColor();
            randomColor2();
            randomColor3();
        }

        public void changeColor()
        {
            byte rr = (byte)red.Value;
            byte gg = (byte)greenn.Value;
            byte bb = (byte)bluee.Value;
            Color cc = Color.FromRgb(rr, gg, bb);
            color.BackgroundColor = cc;
            color.Text = rr.ToString() + "," + gg.ToString() +","+ bb.ToString();
        }
        public async void randomColor()
        {
            Random rnd = new Random();
            NewValue = rnd.Next(0, 256);
            color.Text = NewValue.ToString();
            if (NewValue > red.Value)
            {
                for (int i = (int)red.Value; i < NewValue + 1; i++)
                {
                    red.Value = i;
                    await Task.Run(() => Thread.Sleep(100));
                }
            }
            else if (NewValue < red.Value)
            {
                for (int i = 0; i < NewValue; i++)
                {
                    red.Value = i;
                    await Task.Run(() => Thread.Sleep(100));
                }

            }
        }
        public async void randomColor2()
        {
            Random rnd1 = new Random();
            NewValue = rnd1.Next(0, 256);
            color.Text = NewValue.ToString();
            if (NewValue > greenn.Value)
            {
                for (int i = (int)greenn.Value; i < NewValue + 1; i++)
                {
                    greenn.Value = i;
                    await Task.Run(() => Thread.Sleep(100));
                }
            }
            else if (NewValue < greenn.Value)
            {
                for (int i = 0; i < NewValue; i++)
                {
                    greenn.Value = i;
                    await Task.Run(() => Thread.Sleep(10));
                }

            }

        }
        public async void randomColor3()
        {
            Random rnd3 = new Random();
            NewValue = rnd3.Next(0, 256);
            color.Text = NewValue.ToString();
            if (NewValue > bluee.Value)
            {
                for (int i = (int)bluee.Value; i < NewValue + 1; i++)
                {
                    bluee.Value = i;
                    await Task.Run(() => Thread.Sleep(10));
                }
            }
            else if (NewValue < bluee.Value)
            {
                for (int i = 0; i < NewValue; i++)
                {
                    bluee.Value = i;
                    await Task.Run(() => Thread.Sleep(10));
                }

            }

        }






        private void Bluee_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            changeColor();
        }

        private void Greenn_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            changeColor();
        }

        private void Red_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            changeColor();
        }



    
        }
    }
