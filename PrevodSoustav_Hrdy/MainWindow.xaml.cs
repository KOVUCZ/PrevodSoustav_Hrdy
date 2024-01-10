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

namespace PrevodSoustav_Hrdy
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
            string binText = txtVstup.Text;
            if (JeBinarni(binText))
            {
                txtVystup.Text = BinNaDec(binText).ToString();
            }
            else
            {
                MessageBox.Show("není");
            }
        }

        private ulong BinNaDec(string text)
        {
            var opacne = text.Reverse().ToArray();
            long hodnota = 0;
            for(int i = 0; i < opacne.Length; i++)
            {
                hodnota += Convert.ToInt32(opacne[i]) * Convert.ToInt32 (Math.Pow(2,i)); 
            }
        }

        private bool JeBinarni (string text)
        {
            foreach(var znak in text)
            {
                if (znak != '1' && znak != '0')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
