﻿using System;
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
using WpfApp1.Pages;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameManager.Frame = MainFrame;
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
