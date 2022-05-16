// <copyright file="MainWindow.xaml.cs" company="Kyle David Cummins">
// Copyright (c) Kyle David Cummins. All rights reserved.
// </copyright>

namespace BookStoreWPF
{
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

    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();

            List<ViewBook> books = new List<ViewBook>();

            books.Add(new ViewBook("Book1", "Me Myself", "000-0-00-000000-0", "Fiction", DateTime.Now.Date.ToString("MM/dd/yyyy"), "$9.99", 0));

            this.BookTable.ItemsSource = books;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddFilter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClearFilter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BookTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
