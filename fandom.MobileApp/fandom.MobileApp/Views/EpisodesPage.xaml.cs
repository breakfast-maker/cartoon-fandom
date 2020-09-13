using fandom.MobileApp.ViewModels;
using fandom.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fandom.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EpisodesPage : ContentPage
    {
        public EpisodesViewModel EpisodesVM = null;

        public EpisodesPage()
        {
            InitializeComponent();
            BindingContext = EpisodesVM = new EpisodesViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await EpisodesVM.Init();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as MEpisode;
            await Navigation.PushAsync(new EpisodeDetailsPage(item));
        }
    }
}