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
    public partial class LibraryViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<LibraryDataModel> _libraryData;
        [ObservableProperty]
        private bool _isScrollEnable;
        [ObservableProperty]
        private string _buttonText;
        [ObservableProperty]
        private LibraryDataModel _currentPageSelected;

        private bool _isSkipClicked;
        private LibraryModel _libraryModel;

        public event EventHandler<bool> SkipClickedEventHandler;
        public LibraryViewModel() 
        { 
            _libraryModel = new LibraryModel();
            ButtonText = "Next";
            GetLibraryDisplayDetails();
        }

        private void GetLibraryDisplayDetails()
        {
            _libraryModel.GetLibraryData();
            LibraryData = _libraryModel.LibraryData;
            CurrentPageSelected ??= LibraryData.FirstOrDefault();
        }

        [RelayCommand]
        public void SkipClicked()
        {
            _isSkipClicked = true;
            if (_isSkipClicked)
            {
                SkipClickedEventHandler?.Invoke(this, _isSkipClicked);
                IsScrollEnable = false;
                _isSkipClicked = false;
            }
           
        }

        [RelayCommand]
        public void NextButtonClicked()
        {
            
            if(CurrentPageSelected == LibraryData.Last())
            {                
                SkipClickedEventHandler?.Invoke(this, true);
            }
            else
            {
                var currentItem = LibraryData.IndexOf(CurrentPageSelected);
                CurrentPageSelected = LibraryData[currentItem+1];
                ButtonText = "Next";
                if(CurrentPageSelected == LibraryData.Last())
                {
                    ButtonText = "Finish";
                }
            }
           

        }

    }
}
