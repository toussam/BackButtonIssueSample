﻿using BackButtonIssueSample.Models;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BackButtonIssueSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();
            MasterPageName.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageMenuItem;
            if (item == null) return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPageName.ListView.SelectedItem = null;
        }
    }
}