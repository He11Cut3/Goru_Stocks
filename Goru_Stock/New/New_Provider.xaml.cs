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

namespace Goru_Stock.New
{
    /// <summary>
    /// Логика взаимодействия для New_Provider.xaml
    /// </summary>
    public partial class New_Provider : Window
    {
        private GoruEntities _context;
        private UC_Provider _uc;

        public New_Provider(GoruEntities goruEntities, UC_Provider uC_Provider)
        {
            InitializeComponent();
            this._context = goruEntities;
            this._uc = uC_Provider;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Provider_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите добавить информацию?", "Добавление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.Goru_Provider.Add(new Goru_Provider()
                {
                    Goru_Provider_Surname = Surname.Text,
                    Goru_Provider_Name = Name.Text,
                    Goru_Provider_Patronymic = Patronymic.Text,
                    Goru_Provider_Quantity = Quantity.Text,
                    Goru_Provider_Location = Location.Text,
                    Goru_Provider_Name_Product = Product.Text,
                });
                _context.SaveChanges();
                _uc.Update_Provider();
                this.Close();
            }
        }
    }
}
