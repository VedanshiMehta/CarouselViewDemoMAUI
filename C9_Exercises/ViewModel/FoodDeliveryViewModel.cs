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
     public partial class FoodDeliveryViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<LibraryDataModel> _foodData;
        [ObservableProperty]
        private LibraryDataModel _currentPageSelected;
        [ObservableProperty]
        private int _currentPage;

        private FoodDeliveryModel _foodDeliveryModel;

        public event EventHandler<bool> SkipClickedEventHandler;
        public FoodDeliveryViewModel()
        {
            _foodDeliveryModel = new FoodDeliveryModel();
            GetLibraryDisplayDetails();
        }

        private void GetLibraryDisplayDetails()
        {
            _foodDeliveryModel.GetFoodData();
            FoodData = _foodDeliveryModel.FoodDeliveryData;
            CurrentPageSelected ??= FoodData.FirstOrDefault();
        }


        [RelayCommand]
        public void NextArrowButtonClicked()
        {


            if (CurrentPageSelected == FoodData.Last())
            {
                SkipClickedEventHandler?.Invoke(this, true);
            }
            else
            {
                var currentItem = FoodData.IndexOf(CurrentPageSelected);
                CurrentPageSelected = FoodData[currentItem + 1];
            }


        }
   
    }
}
