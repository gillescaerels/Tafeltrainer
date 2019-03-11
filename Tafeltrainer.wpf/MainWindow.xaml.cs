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

namespace Tafeltrainer.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random rnd;

        public MainWindow()
        {
            InitializeComponent();
        }

        void KeuzeTafel()
        {
            lstTafel.IsEnabled = false;

            int tafel;
            tafel = (int)lstTafel.SelectedItem;

            grdOefenVeld.Visibility = Visibility.Visible;

            lblTafel.Content = tafel;

            txtUitkomst.Text = "";
            txtUitkomst.Focus();

            
        }

        void BevestigingAntwoord()
        {
            string uitkomst = txtUitkomst.Text;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstTafel.Items.Add(1);
            lstTafel.Items.Add(2);
            lstTafel.Items.Add(3);
            lstTafel.Items.Add(4);
            lstTafel.Items.Add(5);
            lstTafel.Items.Add(6);
            lstTafel.Items.Add(7);
            lstTafel.Items.Add(8);
            lstTafel.Items.Add(9);
            lstTafel.Items.Add(10);

            grdOefenVeld.Visibility = Visibility.Hidden;
        }

        private void lstTafel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            KeuzeTafel();
        }
    }
}
