﻿using System;
using System.Collections.Generic;

using ADOPMAUI_Exercise.Models;

namespace ADOPMAUI_Exercise.Views.Lesson05
{
    public partial class ListViewExercise2 : ContentPage
    {
        public ListViewExercise2()
        {
            InitializeComponent();
            ImageList.ItemsSource = CityPicture.List;
        }
        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            //Routing of this page
            Title += $"   ({Shell.Current.CurrentState.Location.ToString()})";
        }

        private async void ImageList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            CityPicture item = (CityPicture)e.Item;
            await DisplayAlert("Tapped", item.ToString(), "OK");
            ((ListView)sender).SelectedItem = null;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("../listviewexercise3");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("../listviewexercise1");
        }
    }
}

