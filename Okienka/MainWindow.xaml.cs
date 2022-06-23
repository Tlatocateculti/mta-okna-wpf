using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Okienka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Title = "Witaj w WPF!";
            //text1.Text = "dodanie 5 + 6 = " + (new Operacje()).Dodaj(5, 6);
            Wynik.Content = Convert.ToDouble(a.Text) + Convert.ToDouble(b.Text);
            
        }

        private void Zmien_Kolor(object sender, RoutedEventArgs e)
        {
           // text1.Text = Mouse.GetPosition(this).ToString();
            this.Background = new SolidColorBrush(
                                            Color.FromRgb(
                                                (byte)Mouse.GetPosition(this).X, 
                                                (byte)Mouse.GetPosition(this).Y, 
                                                (byte)(Mouse.GetPosition(this).X - Mouse.GetPosition(this).Y))
                                            );
        }

        private void a_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Text = "";
        }
    }
}
