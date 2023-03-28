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

namespace Goru_Stock.Edit_Del
{
    /// <summary>
    /// Логика взаимодействия для Edit_Del_Provider.xaml
    /// </summary>
    public partial class Edit_Del_Provider : Window
    {
        private GoruEntities _context;
        private UC_Provider _Main;
        private Goru_Provider _Provider;

        public Edit_Del_Provider(GoruEntities goruEntities, object o, UC_Provider uC_Provider)
        {
            InitializeComponent();
            _context = goruEntities;
            _Provider = (o as Button).DataContext as Goru_Provider;
            _Main = uC_Provider;
            Surname.Text = _Provider.Goru_Provider_Surname;
            Name.Text = _Provider.Goru_Provider_Name;
            Patronymic.Text = _Provider.Goru_Provider_Patronymic;
            Location.Text = _Provider.Goru_Provider_Location;
            Quantity.Text = _Provider.Goru_Provider_Quantity;
            Product.Text = _Provider.Goru_Provider_Name_Product;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Edit_Provider_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите изменить информацию?", "Изменение", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _Provider.Goru_Provider_Surname = Surname.Text;
                _Provider.Goru_Provider_Name = Name.Text;
                _Provider.Goru_Provider_Patronymic = Patronymic.Text;
                _Provider.Goru_Provider_Location = Location.Text;
                _Provider.Goru_Provider_Quantity = Quantity.Text;
                _Provider.Goru_Provider_Name_Product = Product.Text;
                _context.SaveChanges();
                _Main.Update_Provider();
                this.Close();
            }
        }

        private void Del_Provider_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите удалить информацию?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.Goru_Provider.Remove(_Provider);
                _context.SaveChanges();
                _Main.Update_Provider();
                this.Close();
            }
        }

        private void Ent_Provider_Click(object sender, RoutedEventArgs e)
        {
            string A2, A3;
            int A1, A5, A4, A6;
            Random RR = new Random();
            A1 = Convert.ToInt32(Quantity.Text); //Кол-во
            A2 = RR.Next(5000, 100000).ToString(); // Номер
            A3 = Product.Text; // Наименование
            A4 = Convert.ToInt32(Amount.Text);

            if ((MessageBox.Show("Вы уверены, что хотите заказать товар?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                if (A1 > A4)
                {
                    A5 = A1 - A4;
                    A6 = A1 - A5;
                    _Provider.Goru_Provider_Quantity = A5.ToString();
                    string time_day = DateTime.Now.AddDays(7).ToString("dd.MM.yyyy"); //Дата получение
                    _context.Goru_Admission.Add(new Goru_Admission()
                    {
                        Goru_Admission_Name = A3.ToString(),
                        Goru_Admission_Number = A2.ToString(),
                        Goru_Admission_Date = time_day,
                        Goru_Admission_Box = A6.ToString(),
                    });
                    _context.SaveChanges();
                    _Main.Update_Provider();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Количество заказываемого товара - превышает количества товара у поставщика!");
            }
        }
    }
}
