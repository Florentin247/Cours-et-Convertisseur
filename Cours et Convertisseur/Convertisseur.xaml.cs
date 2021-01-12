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
using System.Windows.Shapes;

namespace Cours_et_Convertisseur
{
    /// <summary>
    /// Logique d'interaction pour Convertisseur.xaml
    /// </summary>
    public partial class Convertisseur : Window
    {
        public Convertisseur()
        {
            InitializeComponent();
        }

        private void Bin_Checked(object sender, RoutedEventArgs e)
        {
            NomEntre.Content = Bin.Content;
        }

        private void Hexa_Checked(object sender, RoutedEventArgs e)
        {
            NomEntre.Content = Hexa.Content;
        }

        private void Dec_Checked(object sender, RoutedEventArgs e)
        {
            NomEntre.Content = Dec.Content;
        }

        private void Oct_Checked(object sender, RoutedEventArgs e)
        {
            NomEntre.Content = Oct.Content;
        }

        private void Binout_Checked(object sender, RoutedEventArgs e)
        {
            NomSortie.Content = Binout.Content;
        }

        private void Hexaout_Checked(object sender, RoutedEventArgs e)
        {
            NomSortie.Content = Hexaout.Content;
        }

        private void Decout_Checked(object sender, RoutedEventArgs e)
        {
            NomSortie.Content = Decout.Content;
        }

        private void Octout_Checked(object sender, RoutedEventArgs e)
        {
            NomSortie.Content = Octout.Content;
        }

        private void BtnCours_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Accueil = new MainWindow();
            Accueil.Show();
            // Close this window
            this.Close();
        }

    }
}
