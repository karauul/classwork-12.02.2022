using App1.pages;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.viewmodels
{
    public class viewmodel1:INotifyPropertyChanged
    {
        private int _number = 38;

        public int Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged();
            }
        }

        public async Task ChangeNumber()
        {
            await Task.Delay(1000);
            int random = new Random().Next(300);
            Number = random;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ICommand Label1Command => new Command(async value =>
        {
            await ChangeNumber();
        });

        public ICommand command => new Command(async value =>
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Page2());
        });
    }
}
