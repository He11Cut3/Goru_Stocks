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
    /// Логика взаимодействия для UC_Admission.xaml
    /// </summary>
    public partial class UC_Admission : UserControl
    {
        GoruEntities _context = new GoruEntities();
        List<Goru_Admission> _list = new List<Goru_Admission>();
        private Goru_Admission _Admission;

        public UC_Admission()
        {
            InitializeComponent();
            LV_Admission_.ItemsSource = _context.Goru_Admission.OrderBy(A => A.Goru_Admission_Id).ToList();
            Update_Admission();
        }

        public void Update_Admission()
        {
            _list = _context.Goru_Admission.ToList();
            LV_Admission_.ItemsSource = _list;
        }

        private void Edit_Del_Admission_Click(object o, RoutedEventArgs e)
        {
            _Admission = (o as Button).DataContext as Goru_Admission;
            if ((MessageBox.Show("Вы уверены, что хотите удалить информацию?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.Goru_Admission.Remove(_Admission);
                _context.SaveChanges();
                Update_Admission();
            }
        }
    }
}
