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

namespace FabricStore.pages
{
    /// <summary>
    /// Логика взаимодействия для MaterialDeliveredPage.xaml
    /// </summary>
    public partial class MaterialDeliveredPage : Page
    {
        bdMaterialsEntities context = new bdMaterialsEntities();
        public MaterialDeliveredPage()
        {
            InitializeComponent();
            dataMaterialDelivered.ItemsSource = context.MaterialDeliveries.ToList();
        }
    }
}
