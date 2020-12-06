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
using Menu.Models;
using Menu.Windows;

namespace Menu.Pages
{
    /// <summary>
    /// Interaction logic for PageFile.xaml
    /// </summary>
    public partial class PageFile : Page
    {
        public PageFile()
        {
            InitializeComponent();
            ListFile.ItemsSource = Item.FileItems();
        }

        private void ListFile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView list = sender as ListView;
            Item item = list.SelectedItem as Item;
            var w1 = new WindowDescription(item);
            w1.ShowDialog();
        }
    }
}
