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
using Menu.Models;
using Menu.Pages;

namespace Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListItem.ItemsSource = Item.Items();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GetItem.Frame = GlobalFrame;
        }

        private void ListItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView list = sender as ListView;
            Item item = list.SelectedItem as Item;
            if (item.NameItem=="Базы данных")
            {
                GetItem.Frame.Navigate(new PageData());
            }
            else if (item.NameItem == "Документы")
            {
                GetItem.Frame.Navigate(new PageDoc());
            }
            else if (item.NameItem =="Игры")
            {
                GetItem.Frame.Navigate(new PageGame());
            }
        }
    }
}
