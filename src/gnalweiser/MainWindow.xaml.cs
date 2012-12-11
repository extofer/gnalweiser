using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using gnalweiser.lib;
using System.IO;
using System.Configuration;

namespace gnalweiser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int _ifrom;
        private int _ito;
        private int _rnd;
        //TextWriter tw = new StreamWriter("log.txt");

        public MainWindow()
        {
            InitializeComponent();
            MainForm.Title = GnalCommon.GetVersion();
            TxtLogger.ValidateFile();

        }

        private void rdoFail_Checked(object sender, RoutedEventArgs e)
        {
            TxtLogger.LogTxt( _rnd + " |F");
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            TxtLogger.LogTxt(_rnd + " |P");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtValidateFrom.Visibility = Visibility.Hidden;
                txtValidateTo.Visibility = Visibility.Hidden;
                txtValidate.Visibility = Visibility.Hidden;

                if (GnalCommon.ValidateText(txtFrom.Text))
                {
                    _ifrom = int.Parse(txtFrom.Text);
                }
                else
                {
                    txtValidateFrom.Visibility = Visibility.Visible;
                    txtValidate.Visibility = Visibility.Visible;
                    return;
                }

                if (GnalCommon.ValidateText(txtTo.Text))
                {
                    _ito = int.Parse(txtTo.Text);
                }
                else
                {
                    txtValidateTo.Visibility = Visibility.Visible;
                    txtValidate.Visibility = Visibility.Visible;
                    return;
                }

                int x = Randomizer.GetUnlogRandom(_ifrom, _ito);
                _rnd = x;

                RandomNum.Text = _rnd.ToString();


            }
            catch
            {
            }
        }
            


    }
}
