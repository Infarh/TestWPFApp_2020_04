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
using Microsoft.Win32;
using System.IO;

namespace TestWPFApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Title = "Hello World!";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка нажата!");
        }

        private void RotateAngleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //ButtonRotator.Angle = RotateAngleSlider.Value;
            //TestButton.Content = RotateAngleSlider.Value;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OpenMenu_Click(object sender, RoutedEventArgs e)
        {
            var open_dialog = new OpenFileDialog
            {
                Title = "Открыть файл",
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };

            if(open_dialog.ShowDialog() != true) return;

            var file_name = open_dialog.FileName;

            var file_text = File.ReadAllText(file_name);
            TextEditor.Text = file_text;
        }
    }
}
