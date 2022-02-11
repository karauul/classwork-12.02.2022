using App1.viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private viewmodel1 viewmodel1 = new viewmodel1();
        public Page1()
        {
            InitializeComponent();
            BindingContext = viewmodel1;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await viewmodel1.ChangeNumber();
        }
    }
}