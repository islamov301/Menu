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
using System.Windows.Shapes;
using Menu.Models;

namespace Menu.Windows
{
    /// <summary>
    /// Interaction logic for WindowDescription.xaml
    /// </summary>
    public partial class WindowDescription : Window
    {
        Item Item;
        public WindowDescription(Item item)
        {
            InitializeComponent();
            Item = item;
            this.DataContext = Item;
        }
    }
}
