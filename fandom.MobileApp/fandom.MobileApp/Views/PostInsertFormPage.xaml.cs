using fandom.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
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

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Select image"
            });

            if (result != null)
            {
                var stream = await result.OpenReadAsync();

                var byteArray = ReadFully(stream);
                PostInsertVM.postImage = byteArray;

                postImage.Source = ImageSource.FromStream(() => new MemoryStream(byteArray));
            }

        }

        public  byte[] ReadFully(Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }

        }
    }
}