using C9_Exercises.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Exercises.ViewModel
{
     public partial class FastFoodDeliveryViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<LibraryDataModel> _fastFoodData;
        [ObservableProperty]
        private LibraryDataModel _currentPageSelected;
        [ObservableProperty]
        private Color _colorButton;
        [ObservableProperty]
        private ImageSource _buttonImage;


        private FastFoodDeliveryModel _foodDeliveryModel;

        public event EventHandler<bool> SkipClickedEventHandler;
        public FastFoodDeliveryViewModel()
        {
            _foodDeliveryModel = new FastFoodDeliveryModel();
            GetLibraryDisplayDetails();
        }

        private void GetLibraryDisplayDetails()
        {
            _foodDeliveryModel.GetFoodData();
            ButtonImage = "nextarrow";
            FastFoodData = _foodDeliveryModel.FastFoodData;
            CurrentPageSelected ??= FastFoodData.FirstOrDefault();
        }

        [RelayCommand]
        public void SkipTextClicked()
        {
                SkipClickedEventHandler?.Invoke(this, true);
            
        }

        [RelayCommand]
        public void GoNextPage()
        {

            if (CurrentPageSelected == FastFoodData.Last())
            {
                SkipClickedEventHandler?.Invoke(this, true);
            }
            else
            {
                var currentItem = FastFoodData.IndexOf(CurrentPageSelected);
                CurrentPageSelected = FastFoodData[currentItem + 1];
                ColorButton = CurrentPageSelected.Colors;
                ButtonImage = "nextarrow";
            }


        }
    }
}
