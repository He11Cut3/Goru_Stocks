using Goru_Stock.Edit_Del;
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

namespace Goru_Stock.UC
{
    /// <summary>
    /// Логика взаимодействия для UC_Stock.xaml
    /// </summary>
    public partial class UC_Stock : UserControl
    {
        GoruEntities _context = new GoruEntities();
        List<Goru_Stocks> _list = new List<Goru_Stocks>();
        private Goru_Stocks _Stocks;

        public UC_Stock()
        {
            InitializeComponent();
            LV_Stocks_.ItemsSource = _context.Goru_Stocks.OrderBy(A => A.Goru_Stocks_Id).ToList();
            Update_Stocks();

            string time_day = DateTime.Now.ToString("dd.MM.yyyy");
            var recordsToUpdate = _context.Goru_Admission.Where(x => x.Goru_Admission_Date == time_day).ToList();

            foreach (var duplicate in recordsToUpdate)
            {
                _context.Goru_Admission.Remove(duplicate);
                _context.Goru_Stocks.Add(new Goru_Stocks()
                {
                    Goru_Stocks_Name = duplicate.Goru_Admission_Name,
                    Goru_Stocks_Number = duplicate.Goru_Admission_Number,
                    Goru_Stocks_Date = time_day,
                    Goru_Stocks_Count = duplicate.Goru_Admission_Box,
                    Goru_Stocks_Article = "На корректировке",
                    Goru_Stocks_Description = "На корректировке",
                    Goru_Stocks_Price = "На корректировке",
                    Goru_Stocks_Status = "Прибыл на склад",
                });
            }
            _context.SaveChanges();
            Update_Stocks();
        }

        public void Update_Stocks()
        {
            _list = _context.Goru_Stocks.ToList();
            LV_Stocks_.ItemsSource = _list;
        }

        private void Edit_Del_Stock_Click(object sender, RoutedEventArgs e)
        {
            Edit_Del_Stocks edit_Del_Stock = new Edit_Del_Stocks(_context, sender, this);
            edit_Del_Stock.ShowDialog();
        }

        private void New_Provide_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
