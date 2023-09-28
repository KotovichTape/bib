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
using dk;


namespace bib
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
        bool lol = true;
        bool lang = true;
        private void lolka()
        {
            if (lol == true)
            {
                App.Theme = "Light";

            }
            if (lol == false)
            {
                App.Theme = "Dark";
            }
        }
        private void langue()
        {
            if (lang == true)
            {
                App.Theme = "eng";
            }
            if (lang == false)
            {
                App.Theme = "rus";
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lol == true)
            {
                App.Theme = "Light";
                lol = false;
            }
            else
            {
                App.Theme = "Dark";
                lol = true;
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (lang == true)
            {
                App.Theme = "eng";
                lang = false;
            }
            else
            {
                App.Theme = "rus";
                lang = true;
            }
        }
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void go_Click(object sender, RoutedEventArgs e)
        {
            sohr Sohr = new sohr();
            {
                Sohr.texet = otk.Text;
            }
            Class1.ser(Sohr);
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            string put = "C:\\Users\\Даниил\\Music\\qwe.json";
            var sohr = Class1.des<sohr>(put);
            tect.Text = sohr.texet;
        }
    }
}
