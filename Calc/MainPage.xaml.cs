using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        }

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
            textBlockAns.Text = Convert.ToString(int.Parse(textBox1.Text) / int.Parse(textBox2.Text));
        }
    }

}