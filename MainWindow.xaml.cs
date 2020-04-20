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
using System.Diagnostics;
using System.Threading;

namespace _6az10_2
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Operace operace;
        public MainWindow()
        {
            InitializeComponent();
        }

        List<string> previousText = new List<string>();

        bool overeni=false;

        private void OnKeyDownHandler(object sender, KeyEventArgs a)
        {
            Trace.WriteLine("Stiskla se klávesa " + a.Key);
            RoutedEventArgs e = null;

            if (a.Key == Key.NumPad9)
            {
                object klavesa = (object)Devet_Button;
                Button_Click(klavesa, e);
            }
            else if (a.Key == Key.NumPad8)
            {
                object klavesa = (object)Osm_Button;
                Button_Click(klavesa, e);
            }
            else if (a.Key == Key.NumPad7)
            {
                object klavesa = (object)Sedm_Button;
                Button_Click(klavesa, e);
            }
            else if (a.Key == Key.NumPad6)
            {
                object klavesa = (object)Sest_Button;
                Button_Click(klavesa, e);
            }
            else if (a.Key == Key.NumPad5)
            {
                object klavesa = (object)Pet_Button;
                Button_Click(klavesa, e);
            }
            else if (a.Key == Key.NumPad4)
            {
                object klavesa = (object)Ctyri_Button;
                Button_Click(klavesa, e);
            }
            else if (a.Key == Key.NumPad3)
            {
                object klavesa = (object)Tri_Button;
                Button_Click(klavesa, e);
            }
            else if (a.Key == Key.NumPad2)
            {
                object klavesa = (object)Dva_Button;
                Button_Click(klavesa, e);
            }
            else if (a.Key == Key.NumPad1)
            {
                object klavesa = (object)Jedna_Button;
                Button_Click(klavesa, e);
            }
            else if (a.Key == Key.NumPad0)
            {
                object klavesa = (object)Nula_Button;
                Button_Click(klavesa, e);
            }

            else if (a.Key == Key.Add || a.Key == Key.OemPlus)
            {
                object klavesa = (object)Plus_Button;
                Button_Click(klavesa, e);
            }
            else if (a.Key == Key.Subtract || a.Key == Key.OemMinus)
            {
                object klavesa = (object)Minus_Button;
                Button_Click(klavesa, e);
            }
            else if (a.Key == Key.Multiply)
            {
                object klavesa = (object)Krat_Button;
                Button_Click(klavesa, e);
            }
            else if (a.Key == Key.Divide)
            {
                object klavesa = (object)Lomeno_Button;
                Button_Click(klavesa, e);
            }

            else if (a.Key == Key.C)
            {
                object klavesa = (object)C_Button;
                Button_Click(klavesa, e);
            }

            else if (a.Key == Key.Decimal || a.Key == Key.OemComma)
            {
                object klavesa = (object)DesCarka_Button;
                Button_Click(klavesa, e);
            }

            else if (a.Key == Key.Space)
            {
                object klavesa = (object)RovnaSe_Button;
                Button_Click(klavesa, e);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string objStr = ((Button)sender).Content.ToString();

                if (objStr == (string)RovnaSe_Button.Content)
                {
                        operace = new Operace(Displej_TextBox.Text);
                        Displej_TextBox.Text = operace.Vysledek.ToString();
                        DataContext = operace;
                        overeni = true;
                }

                else if ((objStr == (string)CE_Button.Content))
                {
                    if (previousText.Count() > 0)
                    {
                        Displej_TextBox.Text = previousText[previousText.Count() - 1];
                        previousText.RemoveAt(previousText.Count() - 1);
                        if(overeni == true)
                        {
                            operace.Ulozeni = "";
                            overeni = false;
                        }
                    }
                }

                else if ((objStr == (string)C_Button.Content))
                {
                    Displej_TextBox.Text = "0";
                    previousText = new List<string>();
                    if (overeni == true)
                    {
                        operace.Ulozeni = "";
                        overeni = false;
                    }
                }

                else
                {
                    previousText.Add(Displej_TextBox.Text);
                    if (Displej_TextBox.Text == "0")
                    {
                        Displej_TextBox.Text = "";
                    }
                    Displej_TextBox.Text += objStr;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
