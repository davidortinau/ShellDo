using System;
using Xamarin.Forms;

using ShellDo.Models;
using System.Windows.Input;
using System.Threading.Tasks;

namespace ShellDo.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public NewItemViewModel()
        {
            SaveCommand = new Command(async () => await HandleSave());
            CancelCommand = new Command(async () => await HandleCancel());

            Item = new Item
            {
                Text = "Item name",
                Description = "This is an item description."
            };
        }


        async Task HandleCancel()
        {
            await Shell.Current.Navigation.PopModalAsync();
        }

        async Task HandleSave()
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Shell.Current.Navigation.PopModalAsync();
        }
    }
}
