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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для TourEdit.xaml
    /// </summary>
    public partial class TourEdit : Page
    {
        byte[] im;

        private Tour _currentTour = new Tour();
        bool imgChange = false;
        public TourEdit(Tour selectedTour)
        {
            InitializeComponent();
            if (selectedTour != null)
                _currentTour = selectedTour;
            DataContext = _currentTour;
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (ofd.ShowDialog() == true)
            {
                im = File.ReadAllBytes(ofd.FileName);
                imnn.Source = new BitmapImage(new Uri(ofd.FileName));
                imgChange = true;
            }

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (imnn.Source == null)
            {
                imnn.Source = new BitmapImage(new Uri("/Resources/nophoto.png", UriKind.Relative));
            }
            imgChange = false;
        }
    }
}
