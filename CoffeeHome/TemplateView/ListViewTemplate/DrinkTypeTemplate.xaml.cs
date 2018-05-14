﻿using CoffeeHome.ViewModel;
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

namespace CoffeeHome.TemplateView.ListViewTemplate
{
    /// <summary>
    /// Interaction logic for DrinkTypeTemplate.xaml
    /// </summary>
    public partial class DrinkTypeTemplate : UserControl
    {
        public DrinkTypeTemplate()
        {
            InitializeComponent();
            DataContext = new DrinkTypeViewModel();
        }

        private void SnackbarErrorMessage_ActionClick(object sender, RoutedEventArgs e)
        {
            SnackbarError.IsActive = false;
        }
        private void SnackbarSuccessMessage_ActionClick(object sender, RoutedEventArgs e)
        {
            SnackbarSuccess.IsActive = false;
        }
    }
}
