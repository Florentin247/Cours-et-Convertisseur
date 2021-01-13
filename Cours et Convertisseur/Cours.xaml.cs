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
    /// Logique d'interaction pour Cours.xaml
    /// </summary>
    public partial class Cours : Window
    {
        public Cours()
        {
            InitializeComponent();
        }

        private void Maths_Click(object sender, RoutedEventArgs e)
        {
            // Si var == visible, assigner la valeur Visibility.Hidden Sinon Mettre var a Visibility.Visible
            MMaths.Visibility = MMaths.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
            MSIN.Visibility = Visibility.Hidden;
            MPhysique.Visibility = Visibility.Hidden;
            MChimie.Visibility = Visibility.Hidden;
        }

        private void Physique_Click(object sender, RoutedEventArgs e)
        {
            // Si var == visible, assigner la valeur Visibility.Hidden Sinon Mettre var a Visibility.Visible
            MPhysique.Visibility = MPhysique.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
            MSIN.Visibility = Visibility.Hidden;
            MMaths.Visibility = Visibility.Hidden;
            MChimie.Visibility = Visibility.Hidden;
        }

        private void Chimie_Click(object sender, RoutedEventArgs e)
        {
            MChimie.Visibility = MChimie.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
            MPhysique.Visibility = Visibility.Hidden;
            MMaths.Visibility = Visibility.Hidden;
            MSIN.Visibility = Visibility.Hidden;
        }

        private void Sin_Click(object sender, RoutedEventArgs e)
        {
            MSIN.Visibility = MSIN.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
            MPhysique.Visibility = Visibility.Hidden;
            MMaths.Visibility = Visibility.Hidden;
            MChimie.Visibility = Visibility.Hidden;
        }

        private void MMaths_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine(((Button)sender).Content);

            switch ((string)((Button)sender).Content)
            {
                case "Chapitre 1":
                    Console.WriteLine("Chapitre 1");
                    String fileName = @"D:\Terminale_Sin\Physique chimie\Cours\Chapitre 4\Cours_chap4.pdf";
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = fileName;
                    process.Start();
                    break;

                case "Salut toi !":
                    Console.WriteLine("Chapitre 2");
                    break;

                default:
                    Console.WriteLine("Chapitre 3");
                    break;
            }
        }
        private void MPhysique_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine(((Button)sender).Content);

            switch ((string)((Button)sender).Content)
            {
                case "Chapitre 1":
                    Console.WriteLine("Chapitre 1");
                    String C1 = @"D:\Terminale_Sin\Physique chimie\Cours\Chapitre 1\Cours_chap1.pdf";
                    System.Diagnostics.Process process1 = new System.Diagnostics.Process();
                    process1.StartInfo.FileName = C1;
                    process1.Start();
                    break;

                case "Chapitre 2":
                    Console.WriteLine("Chapitre 2");
                    break;
                        
                default:
                    Console.WriteLine("Chapitre 3");
                    String Chap1 = "Cours_chap4.pdf";
                    System.Diagnostics.Process process_Chap1 = new System.Diagnostics.Process();
                    process_Chap1.StartInfo.FileName = Chap1;
                    process_Chap1.Start();
                    break;
            }
        }
        private void MChimie_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine(((Button)sender).Content);

            switch ((string)((Button)sender).Content)
            {
                case "Je suis un bouton":
                    Console.WriteLine("Chapitre 1");
                    String fileName = @"D:\Terminale_Sin\Physique chimie\Cours\Chapitre 4\Cours_chap4.pdf";
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = fileName;
                    process.Start();
                    break;

                case "Salut toi !":
                    Console.WriteLine("Chapitre 2");
                    break;

                default:
                    Console.WriteLine("Chapitre 3");
                    break;
            }
        }
        private void MSIN_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine(((Button)sender).Content);

            switch ((string)((Button)sender).Content)
            {
                case "HTML":
                    Console.WriteLine("HTML");
                    String HTML = @"C:\Users\Excalibur\source\repos\Cours et Convertisseur\Cours et Convertisseur\Cours_PDF\Cours_chap2.pdf";
                    System.Diagnostics.Process HTMLProc = new System.Diagnostics.Process();
                    HTMLProc.StartInfo.FileName = HTML;
                    HTMLProc.Start();
                    break;

                case "CSS":
                    Console.WriteLine("CSS");
                    break;

                case "Javascript":
                    Console.WriteLine("Javascript");
                    break;

                case "Python":
                    Console.WriteLine("x");
                    break;

                default:
                    Console.WriteLine("Chapitre 3");
                    break;
            }
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
