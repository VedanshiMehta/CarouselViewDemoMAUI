using C9_Exercises.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace C9_Exercises.ViewModel
{
    public partial class DemoViewModel : INotifyPropertyChanged
    {

       
        private ObservableCollection<LibraryDataModel> _foodData;
       
        private int _currentPage;

        public ObservableCollection<LibraryDataModel> FoodData { get => _foodData; set { _foodData = value; OnPropertyChanged(); } }
        public int CurrentPage { get => _currentPage; set { _currentPage = value; OnPropertyChanged(); } }

        private FoodDeliveryModel _foodDeliveryModel;

        public event EventHandler<bool> SkipClickedEventHandler;
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand Next { get; private set; }

        public DemoViewModel()
        {
            _foodDeliveryModel = new FoodDeliveryModel();
            Next = new Command(NextArrowButtonClicked);
            GetLibraryDisplayDetails();
        }

        private void GetLibraryDisplayDetails()
        {
            _foodDeliveryModel.GetFoodData();
            FoodData = _foodDeliveryModel.FoodDeliveryData;
        }


        public void NextArrowButtonClicked()
        {


            if (CurrentPage == FoodData.Count-1)
            {
                SkipClickedEventHandler?.Invoke(this, true);
            }
            else
            {
                CurrentPage++;
            }


        }
        public void OnPropertyChanged([CallerMemberName]string propertyName ="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
