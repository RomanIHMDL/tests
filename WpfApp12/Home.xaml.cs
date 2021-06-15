using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace WpfApp12
{
    /// <summary>
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        Database1Entities qwe = new Database1Entities();
        public Home()
        {
            InitializeComponent();
            qwe.House.Load();
            rty.ItemsSource = qwe.House.Local.ToBindingList();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            qwe.House.Add(new House()
            {
                ResidentialComplexID = Convert.ToInt32(ResidentialComplexID1.Text.Trim()),
                Street = Street1.Text.Trim(),
                Number = Number1.Text.Trim(),
                BuildingCost = Convert.ToInt32(BuildingCost1.Text.Trim()),
                HouseValueAdded = Convert.ToInt32(HouseValueAdded1.Text.Trim())
            }

            );
            try
            {
                qwe.SaveChanges();
            }
            catch { MessageBox.Show("неверные данные"); }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            {MessageBox.Show("помогу"); }
        }
    }
}
 
      


