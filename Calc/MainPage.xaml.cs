using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using System.Text.RegularExpressions;
using Windows.Devices.Power;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Calc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            textBlockAns.Text = " ";
        }
        int baza = 10;
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBlockAns.Text = Convert.ToString(int.Parse(textBox1.Text) + int.Parse(textBox2.Text));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBlockAns.Text = Convert.ToString(int.Parse(textBox1.Text) - int.Parse(textBox2.Text));
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            textBlockAns.Text = Convert.ToString(int.Parse(textBox1.Text) * int.Parse(textBox2.Text));
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textBlockAns.Text = Convert.ToString(double.Parse(textBox1.Text) / double.Parse(textBox2.Text));
        }

        private void Octal_Checked(object sender, RoutedEventArgs e)
        {
            textBlockAns.Text = Convert.ToString(Convert.ToInt32(textBlockAns.Text, baza), 8);
            baza = 8;
        }

        private void binary_Checked(object sender, RoutedEventArgs e)
        {
            textBlockAns.Text = Convert.ToString(Convert.ToInt32(textBlockAns.Text, baza), 2);
            baza = 2;
        }

        private void hex_Checked(object sender, RoutedEventArgs e)
        {
            textBlockAns.Text = Convert.ToString(Convert.ToInt32(textBlockAns.Text, baza), 16);
            baza= 16;
        }

        private void _decimal_Checked(object sender, RoutedEventArgs e)
        {
            textBlockAns.Text = Convert.ToString(Convert.ToInt32(textBlockAns.Text, baza), 10);
            baza = 10;
        }

        private void textBox1_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            string pattern = "[^0-9]";
            switch(baza)
            {
                case (2):
                    pattern = "[^0-1]";
                    break;
                case (8):
                    pattern = "[^0-7]";
                    break;
                case (10):
                    pattern = "[^0-9]";
                    break;
                case (16):
                    pattern = "[^0-F]";
                    break;

            }
            if (Regex.IsMatch(textBox1.Text, pattern))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox1_TextChanging(object sender, TextChangedEventArgs e)
        {

        }
    }

} 