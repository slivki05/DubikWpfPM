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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Pages;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameManager.Frame = MainFrame;
            ImportTours();
        }
        private void ImportTours()
        {
            var fileData = File.ReadAllLines(@"C:\Users\regin\Desktop\Туры.txt");
            var images = Directory.GetFiles(@"C:\Users\regin\Desktop\import до\Туры фото");

            foreach (var line in fileData)
            {
                var data = line.Split('\t');
                var tempTour = new Tour
                {
                    Name = data[0].Replace("\"", ""),
                    TicketCount = int.Parse(data[2]),
                    Price = decimal.Parse(data[3]),
                    isActual = (data[4] == "0") ? false : true
                };
                foreach (var tourType in data[5].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                {
                    var currentType = TourBaseEntities.GetContext().Type.ToList().FirstOrDefault(p => p.Name == tourType);
                    if (currentType != null)
                        tempTour.Type.Add(currentType);
                }
                try
                {
                    tempTour.ImagePreview = File.ReadAllBytes(images.FirstOrDefault(p => p.Contains(tempTour.Name)));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                TourBaseEntities.GetContext().Tour.Add(tempTour);
                TourBaseEntities.GetContext().SaveChanges();
            }
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.Frame.Navigate(new MainPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameManager.Frame.Navigate(new Page1());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameManager.Frame.Navigate(new Page2());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FrameManager.Frame.Navigate(new Page3());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FrameManager.Frame.Navigate(new Page4());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            FrameManager.Frame.Navigate(new Page5());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            FrameManager.Frame.Navigate(new Page6());
        }
    }
}