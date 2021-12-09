using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для MaterialEditPage.xaml
    /// </summary>
    public partial class MaterialEditPage : Page
    {
        bdMaterialsEntities context;
        public MaterialEditPage(bdMaterialsEntities context, Material currentMaterial)
        {
            InitializeComponent();
            this.context = context;
            DataContext = currentMaterial;

            materialIDTextBlock.Text = "ID: " + currentMaterial.ID;
            cmbType.ItemsSource = context.TypeMaterials.ToList();
        }

        private void btnAddImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*.jpg, *.jpeg, *.png|*.jpg;*.jpeg;*.png;";
            ofd.ShowDialog();
            string pathOFD = ofd.FileName;
            byte[] image = File.ReadAllBytes(pathOFD);
            var add = this.DataContext as Material;
            add.Image = image;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.currentFrame.Navigate(new MaterialMainPage());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            FrameManager.currentFrame.Navigate(new MaterialMainPage());
        }
    }
}
