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
    public partial class CreditCardDataViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<CardsModel> _cards;
        [ObservableProperty]
        private string _cardName;
        [ObservableProperty]
        private string _cardLimit;
        private CreditCardModel _creditCardModel;
        private CardsModel _currentItem { get; set; }


        public CreditCardDataViewModel() 
        { 
            
            _creditCardModel = new CreditCardModel();
            GetCardDetails();
        }

        private void GetCardDetails()
        {
            _creditCardModel.GetListOfCards();
            Cards = _creditCardModel.Cards;
            CardName = Cards[0].CardName;
            CardLimit = Cards[0].Limit.ToString();

        }

        [RelayCommand]
        public void CurrentItemSelected(CardsModel cardsModel)
        {
            if (cardsModel != null)
            {
                CardName = cardsModel.CardName;
                CardLimit = cardsModel.Limit.ToString();
            }
        }
    }
}
