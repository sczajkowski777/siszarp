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

namespace siszarp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private RadioButton GetActiveRadioButton()
        {
            List<RadioButton> radioButtons = new List<RadioButton> { rbniebieski, rbzielony, rbpiwny };
            foreach (RadioButton rb in radioButtons)
            {
                if (rb.IsChecked == true)
                {
                    return rb;
                }
            }
            return null;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(tbImie.Text) || String.IsNullOrEmpty(tbNazwisko.Text) )
            {
                MessageBox.Show("Wprowadź dane.", "Błąd!");
            } else
            {
                RadioButton currentRadioButton = GetActiveRadioButton();
                MessageBox.Show(String.Format("{0} {1} kolor oczu {2}", tbImie.Text, tbNazwisko.Text, currentRadioButton.Content));
            }
        }      
    }
}
