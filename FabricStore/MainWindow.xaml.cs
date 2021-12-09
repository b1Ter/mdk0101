using FabricStore.pages;
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

namespace FabricStore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameManager.currentFrame = currentFrame;
            FrameManager.currentFrame.Navigate(new MaterialMainPage());
        }

        private void btnMaterialShow_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.currentFrame.Navigate(new MaterialMainPage());
        }

        private void btnSoldShow_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.currentFrame.Navigate(new SoldMaterialPage());
        }

        private void btnDeliveredShow_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.currentFrame.Navigate(new MaterialDeliveredPage());
        }
    }
}
