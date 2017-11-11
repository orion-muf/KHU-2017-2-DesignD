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

namespace SoccerTradingSystem.Views
{
    /// <summary>
    /// ClubDetailWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ClubDetailWindow : Window
    {
        public ClubDetailWindow()
        {
            InitializeComponent();
        }

        private void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            if (App.cookie != null)
            {
                ClubOfferBtn.Visibility = System.Windows.Visibility.Visible;
                //if (App.cookie.userType == "Club")
                //{
                //    PlayerOfferBtn.Visibility = System.Windows.Visibility.Visible;
                //}
                //else
                //{
                //    PlayerOfferBtn.Visibility = System.Windows.Visibility.Collapsed;
                //}
            }
        }
    }
}