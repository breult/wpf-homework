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

namespace SubmitButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent();
        }

        private void TextChanged (object sender, TextChangedEventArgs e)
        {
            
            var boxName = sender as TextBox;
            var boxPassword = sender as TextBox;

            

            if (!string.IsNullOrEmpty(uxName.Text) && (!string.IsNullOrEmpty(uxPassword.Text)))
            {
                uxSubmit.IsEnabled = boxName.Text.Length > 0;
                uxSubmit.IsEnabled = boxPassword.Text.Length > 0;
                uxSubmit.IsEnabled = true;
                
            }
           
        }

        private void uxSubmit_Click (object sender, RoutedEventArgs e)
        {

                MessageBox.Show("Submitting info");
        }
    }
}
