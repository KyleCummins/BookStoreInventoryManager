// <copyright file="App.xaml.cs" company="Kyle David Cummins">
// Copyright (c) Kyle David Cummins. All rights reserved.
// </copyright>

namespace BookStoreWPF
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows;

    /// <summary>
    /// Interaction logic for App.xaml.
    /// </summary>
    public partial class App : Application
    {
        /*
        /// <summary>
        /// Startup code to bind view to viewmodel.
        /// </summary>
        /// <param name="e">Event arguments.</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            ViewModel? vm = Application.Current.FindResource("ViewModel") as ViewModel;

            MainWindow? mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

            vm.PropertyChanged += mainWindow.OnViewModelPropertyChanged;

            base.OnStartup(e);
        }
        */
    }

}
