﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AwesomeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;
        private void Handle_Clicked(object sender, EventArgs e)
        {
            count += 1;
            ((Button)sender).Text = $"You clicked {count} times.";
        }
    }
}
