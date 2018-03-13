using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvxBindError.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private IList<float> _items;
        public IList<float> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public override async Task Initialize()
        {
            Items = new List<float> { 40 };
        }
    }
}
