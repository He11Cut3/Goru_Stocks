using Goru_Stock.Edit_Del;
using Goru_Stock.New;
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
    /// Логика взаимодействия для UC_Provider.xaml
    /// </summary>
    public partial class UC_Provider : UserControl
    {
        GoruEntities _context = new GoruEntities();
        List<Goru_Provider> _list = new List<Goru_Provider>();
        private Goru_Provider _Provider;

        public UC_Provider()
        {
            InitializeComponent();
            LV_Provider_.ItemsSource = _context.Goru_Provider.OrderBy(A => A.Goru_Provider_Id).ToList();
            Update_Provider();
        }

        public void Update_Provider()
        {
            _list = _context.Goru_Provider.ToList();
            LV_Provider_.ItemsSource = _list;
        }

        private void New_Provide_Click(object sender, RoutedEventArgs e)
        {
            New_Provider new_Provider = new New_Provider(_context, this);
            new_Provider.ShowDialog();
        }

        private void Edit_Del_Provider_Click(object sender, RoutedEventArgs e)
        {
            Edit_Del_Provider edit_Del_Provider = new Edit_Del_Provider(_context, sender, this);
            edit_Del_Provider.ShowDialog();
        }
    }
}
