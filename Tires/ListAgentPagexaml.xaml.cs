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

namespace Tires
{
    /// <summary>
    /// Логика взаимодействия для ListAgentPagexaml.xaml
    /// </summary>
    public partial class ListAgentPagexaml : Page
    {
        public ListAgentPagexaml()
        {
            InitializeComponent();
            var allTypes = TiresEntities.GetContext().ProductType.ToList();
            allTypes.Insert(0, new ProductType
            {
                Title = "Все типы"
            });
            ComboType.ItemsSource = allTypes;
            ComboType.SelectedIndex = 0;

            LVAgent.ItemsSource = TiresEntities.GetContext().Product.ToList();
        }

        private void UpdateProduct()
        {
            
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboType.SelectedIndex == 1)
            {
                
            }
        }
    }
}
