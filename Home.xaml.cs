using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventParadigmExample
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string productName = txtProductName.Text;
            string status = lblCategory.Content.ToString();
            string category = cboSize.Text;
            string fecha = calendario.SelectedDate.ToString();

            txtResults.Text = txtResults.Text + productName + "\n" + category + "\n" + status +"\n"+ fecha;

            if (checkInStock.IsChecked.Value && checkOutStock.IsChecked.Value)
            {
                MessageBox.Show("Just check one status");
            }
            else
            {
            if (checkInStock.IsChecked.Value)
            {
                txtResults.Text = txtResults.Text+"\n" + "Available"+"\n"+"\n";
            };
            if (checkOutStock.IsChecked.Value)
            {
                txtResults.Text = txtResults.Text + "\n" + "Not vailable"+"\n"+"\n";
            };
            }
 
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.IsChecked.Value)
            {
                lblCategory.Content = rb.Content.ToString();
            }
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.frameMain.NavigationService.Navigate(new Login());
        }
    }
}
