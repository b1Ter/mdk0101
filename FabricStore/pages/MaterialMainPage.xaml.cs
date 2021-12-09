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
    /// Логика взаимодействия для MaterialMainPage.xaml
    /// </summary>
    public partial class MaterialMainPage : Page
    {
        bdMaterialsEntities context = new bdMaterialsEntities();
        public MaterialMainPage()
        {
            InitializeComponent();
            dataMaterials.ItemsSource = context.Materials.ToList();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var row = (Material)dataMaterials.SelectedItem;
            if (row == null)
            {
                MessageBox.Show("Select row for deleting, please",
                    "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBoxResult result = MessageBox.Show("Are you sure about deleting this row?",
                "Delete question", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                context.Materials.Remove(row);
                context.SaveChanges();
                dataMaterials.UpdateLayout();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var newMaterial = new Material();
            context.Materials.Add(newMaterial);
            FrameManager.currentFrame.Navigate(new MaterialEditPage(context, newMaterial));
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button btnEdit = (Button)sender;
            var thisMaterial = btnEdit.DataContext as Material;
            FrameManager.currentFrame.Navigate(new MaterialEditPage(context, thisMaterial)) ;
        }
    }
}
