using fandom.MobileApp.ViewModels;
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
    public partial class PostInsertFormPage : ContentPage
    {
        public PostInsertViewModel PostInsertVM = null;

        public PostInsertFormPage()
        {
            InitializeComponent();
            BindingContext = PostInsertVM = new PostInsertViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await PostInsertVM.LoadFields();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await PostInsertVM.InsertPost();
        }
    }
}