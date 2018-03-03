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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent();
            //maximize the window with code
            //use WindowState
            // WindowState = WindowState.Maximized;
        }
        private void TextBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox boxName = sender as TextBox;

            uxSubmit.IsEnabled = boxName.Text.Length > 0;
        }

        private void TextBoxPassword_TextChanged (object sender, TextChangedEventArgs e)
        {
            TextBox boxPassword = sender as TextBox;

            uxSubmit.IsEnabled = boxPassword.Text.Length > 0;
        }

        ////Assignment 1- Disabling Submit unless uxName and uxPassword have text
       private void uxSubmit_Click (object sender, RoutedEventArgs e)
        {
          //default state of uxSubmit is not enabled
           uxSubmit.IsEnabled = false;


            //conditional statement to determine if textboxes Name and Password contain text
            if (string.IsNullOrEmpty(uxName.Text) && (string.IsNullOrEmpty(uxPassword.Text)))
            {
                MessageBox.Show("Cannot have empty text boxes.");
            }
            else
            {

                uxSubmit.IsEnabled = true;

                //from previous in class excercise creating message to user upon submit button click
                MessageBox.Show("Submitting password: " + uxPassword.Text);
            }

        }

        
    }//end Main Window
}//end HelloWorld
