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
    using System.ComponentModel;

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
        }

        /// <summary>
        /// Update view when viewmodel changes.
        /// </summary>
        /// <param name="source">Source of event.</param>
        /// <param name="e">Event args.</param>
        public void OnViewModelPropertyChanged(object source, PropertyChangedEventArgs e)
        {
            this.BookTable.Items.Refresh();
        }

        private void BookTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
