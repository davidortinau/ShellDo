using System;
using Xamarin.Forms;

using ShellDo.Models;

namespace ShellDo.ViewModels
{
    [QueryProperty("ID", "id")]
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel()
        {
            //Title = item?.Text;
            //Item = item;
        }

        private string _id;
        public string ID
        {
            set
            {
                _id = value;
                SetItem();
            }
        }

        private async void SetItem()
        {
            Item item = await DataStore.GetItemAsync(_id);
            Title = item?.Text;
            Item = item;
            OnPropertyChanged(nameof(Item));
        }
    }
}
