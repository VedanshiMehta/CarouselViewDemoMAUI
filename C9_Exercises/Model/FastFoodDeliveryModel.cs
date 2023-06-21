using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Exercises.Model
{
    public class FastFoodDeliveryModel
    {
        public ObservableCollection<LibraryDataModel> FastFoodData { get; set; }
        public void GetFoodData()
        {
            FastFoodData = new ObservableCollection<LibraryDataModel>()
            {
                new LibraryDataModel() { Icon = "fastfood",Colors = Color.Parse("#F1621F"),Title="Choose your favourite food",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. In facilisis nulla eu felis fringilla vulputate. Nullam porta eleifend lacinia. Donec at iaculis tellus." },
                new LibraryDataModel() { Icon = "deliveryleft",Colors = Color.Parse("#399D64"),Title="Get delivery at your door steps",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. In facilisis nulla eu felis fringilla vulputate. Nullam porta eleifend lacinia. Donec at iaculis tellus." },
                new LibraryDataModel() { Icon = "smartphone", Colors = Color.Parse("#0D87DA"),Title="We have 70000+ reviews on our app",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. In facilisis nulla eu felis fringilla vulputate. Nullam porta eleifend lacinia. Donec at iaculis tellus." },
            };
        }
    }
}
