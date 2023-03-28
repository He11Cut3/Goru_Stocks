using Goru_Stock.UC;
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

namespace Goru_Stock
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Stock_Click(object sender, RoutedEventArgs e)
        {
            LV_Provider.Children.Clear();
            LV_Admission.Children.Clear();
            LV_Shipment.Children.Clear();

            UC_Stock uC_Stock = new UC_Stock();
            LV_Stock.Children.Add(uC_Stock);
        }

        private void Provider_Click(object sender, RoutedEventArgs e)
        {
            LV_Stock.Children.Clear();
            LV_Admission.Children.Clear();
            LV_Shipment.Children.Clear();

            UC_Provider uC_Provider = new UC_Provider();
            LV_Provider.Children.Add(uC_Provider);
        }

        private void Admission_Click(object sender, RoutedEventArgs e)
        {
            LV_Stock.Children.Clear();
            LV_Provider.Children.Clear();
            LV_Shipment.Children.Clear();

            UC_Admission uC_Admission = new UC_Admission();
            LV_Admission.Children.Add(uC_Admission);
        }

        private void Shipment_Click(object sender, RoutedEventArgs e)
        {
            LV_Stock.Children.Clear();
            LV_Provider.Children.Clear();
            LV_Admission.Children.Clear();

            UC_Shipment uC_Shipment = new UC_Shipment();
            LV_Shipment.Children.Add(uC_Shipment);
        }
    }
}

