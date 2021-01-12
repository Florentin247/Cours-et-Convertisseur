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

namespace Cours_et_Convertisseur
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnConv_Click(object sender, RoutedEventArgs e)
        {
            Convertisseur PageConv = new Convertisseur();
            PageConv.Show();
            // Close this window
            this.Close();
        }

        private void BtnCours_Click(object sender, RoutedEventArgs e)
        {
            Cours PageCours = new Cours();
            PageCours.Show();
            // Close this window
            this.Close();
            
        }

    }
}
