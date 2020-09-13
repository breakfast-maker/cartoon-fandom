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
    public partial class EpisodeDetailsPage : ContentPage
    {
        EpisodeDetailsViewModel EpisodeDetailsVM = null;
        public EpisodeDetailsPage(MEpisode episode)
        {
            InitializeComponent();
            BindingContext = EpisodeDetailsVM = new EpisodeDetailsViewModel { Episode = episode };
            EpisodeDetailsVM.CheckRelation();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
           await EpisodeDetailsVM.UpdateViewCount();
        }
    }
}