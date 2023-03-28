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
    /// Логика взаимодействия для Edit_Del_Stocks.xaml
    /// </summary>
    public partial class Edit_Del_Stocks : Window
    {
        private GoruEntities _context;
        private UC_Stock _Main;
        private Goru_Stocks _Stocks;

        public Edit_Del_Stocks(GoruEntities goruEntities, object o, UC_Stock uC_Stock)
        {
            InitializeComponent();
            _context = goruEntities;
            _Stocks = (o as Button).DataContext as Goru_Stocks;
            _Main = uC_Stock;
            Name.Text = _Stocks.Goru_Stocks_Name;
            Article.Text = _Stocks.Goru_Stocks_Article;
            Price.Text = _Stocks.Goru_Stocks_Price;
            Count.Text = _Stocks.Goru_Stocks_Count;
            Description.Text = _Stocks.Goru_Stocks_Description;
            Date.Text = _Stocks.Goru_Stocks_Date;
            Number.Text = _Stocks.Goru_Stocks_Number;
            Status.Text = _Stocks.Goru_Stocks_Status;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Edit_Provider_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите изменить информацию?", "Изменение", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _Stocks.Goru_Stocks_Name = Name.Text;
                _Stocks.Goru_Stocks_Article = Article.Text;
                _Stocks.Goru_Stocks_Price = Price.Text;
                _Stocks.Goru_Stocks_Count = Count.Text;
                _Stocks.Goru_Stocks_Description = Description.Text;
                _Stocks.Goru_Stocks_Date = Date.Text;
                _Stocks.Goru_Stocks_Number = Number.Text;
                _Stocks.Goru_Stocks_Status = Status.Text;
                _context.SaveChanges();
                _Main.Update_Stocks();
                this.Close();
            }
        }

        private void Del_Provider_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите удалить информацию?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.Goru_Stocks.Remove(_Stocks);
                _context.SaveChanges();
                _Main.Update_Stocks();
                this.Close();
            }
        }
    }
}
