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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void MovePhotosWithProgressBar()
        {
            double progressBarStep = 100.0 / photoStackPanel.Children.Count;

            for (int i = 0; i < photoStackPanel.Children.Count; i++)
            {
                progressBar.Value = (i + 1) * progressBarStep;
                photoStackPanel.Children[i].SetValue(ScrollViewer.HorizontalOffsetProperty, i * 100);
                System.Threading.Thread.Sleep(500);
            }

            progressBar.Value = 0;

        }

       private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
{
       Image clickedImage = (Image)sender;
 
       var newWindow = new Window();
      newWindow.WindowStyle = WindowStyle.SingleBorderWindow;
      newWindow.ResizeMode = ResizeMode.CanResize;
      newWindow.Content = new Image { Source = clickedImage.Source };
      newWindow.Show();
}  





    }
}