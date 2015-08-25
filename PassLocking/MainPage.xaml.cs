using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PassLocking
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
        String pass = "6006";
        String Enter = "";

        private void B1_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            Enter += "1";
            Display.Text = Enter;
        }

        private void B2_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            Enter += "2";
            Display.Text = Enter;
        }

        private void B3_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            Enter += "3";
            Display.Text = Enter;
        }

        private void B4_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            Enter += "4";
            Display.Text = Enter;
        }

        private void B5_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            Enter += "5";
            Display.Text = Enter;
        }

        private void B6_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            Enter += "6";
            Display.Text = Enter;
        }

        private void B7_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            Enter += "7";
            Display.Text = Enter;
        }

        private void B8_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            Enter += "8";
            Display.Text = Enter;
        }

        private void B9_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            Enter += "9";
            Display.Text = Enter;
        }

        private void B0_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            Enter += "0";
            Display.Text = Enter;
        }

        private async void B_Enter_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handlEer implementation here.
            MessageDialog dlg;
            if (Enter.Length != 4)
            {
                dlg = new MessageDialog("Password is 4 charactor", "Error");
            }
            else if(Enter == pass)
            {
                dlg = new MessageDialog("It's Correct Password", "Access Granted");
            }
            else
            {
                dlg = new MessageDialog("You Enter Wrong Password", "Access Denied");
            }
            await dlg.ShowAsync();
            Enter = "";
            Display.Text = Enter;
        }

        private void B1_Copy2_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            Enter = "";
            Display.Text = Enter;
        }

        private void Path_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			Enter = "6006";
			Display.Text = Enter;
		}
    }
}
