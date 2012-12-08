using System.Windows;
using gnalweiser.lib;
using System.IO;

namespace gnalweiser
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

        
        private int _rnd;
        TextWriter tw = new StreamWriter("log.txt");

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
            int ifrom =  int.Parse(txtFrom.Text);
            int ito = int.Parse(txtTo.Text);

            int x = Randomizer.GetRandom(ifrom, ito);

            _rnd = x;

            RandomNum.Text = _rnd.ToString();


        }
    }
}
