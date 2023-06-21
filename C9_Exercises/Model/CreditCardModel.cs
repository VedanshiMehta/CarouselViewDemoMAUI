using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Exercises.Model
{
    public class CreditCardModel
    {
        public ObservableCollection<CardsModel> Cards { get; set; }

        public void GetListOfCards()
        {
            Cards = new ObservableCollection<CardsModel>()
            {
                new CardsModel() {ImageSource="cardimage1",CardName="MTB",Limit=45000},
                new CardsModel(){ImageSource="cardimage2", CardName="Yes Bank",Limit=50000},
                new CardsModel(){ImageSource ="cardimage3",CardName="HBSC Premier",Limit=58000},
            };
        }

    }
}
