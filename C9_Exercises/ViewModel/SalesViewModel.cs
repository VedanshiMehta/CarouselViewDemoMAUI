using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Exercises.ViewModel
{
    public partial class SalesViewModel:ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ImageSource> _imageList;

        public SalesViewModel()
        {
            GetSalesImageList();
        }

        private void GetSalesImageList()
        {
            ImageList = new ObservableCollection<ImageSource>();
            ImageList.Add("dotnet_bot");
            ImageList.Add("dotnet_bot");
            ImageList.Add("dotnet_bot");
        }
    }
}
