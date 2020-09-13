using fandom.Mobile.ViewModels;
using fandom.Model.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace fandom.MobileApp.ViewModels
{
    public class EpisodesViewModel : BaseViewModel
    {
        private readonly APIService _seasonApiService = new APIService("Season");

        public EpisodesViewModel()
        {
            Initialize = new Command(async () => await Init());
        }

        public ObservableCollection<MSeason> Seasons { get; set; } = new ObservableCollection<MSeason>();

        public ICommand Initialize;



        public async Task Init()
        {
            var list = await _seasonApiService.Get<IEnumerable<MSeason>>();
            Seasons.Clear();
            foreach (var item in list)
            {
                Seasons.Add(item);
            }

        }
    }
}
