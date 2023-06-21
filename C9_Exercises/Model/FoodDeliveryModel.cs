using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Exercises.Model
{
    public class FoodDeliveryModel
    {
        public ObservableCollection<LibraryDataModel> FoodDeliveryData { get; set; }
        public void GetFoodData()
        {
            FoodDeliveryData = new ObservableCollection<LibraryDataModel>()
            {
                new LibraryDataModel() { Icon = "restaurant",Title="Delicious Food",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. In facilisis nulla eu felis fringilla vulputate. Nullam porta eleifend lacinia. Donec at iaculis tellus." },
                new LibraryDataModel() { Icon = "delivery",Title="Free Delivery",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. In facilisis nulla eu felis fringilla vulputate. Nullam porta eleifend lacinia. Donec at iaculis tellus." },
                new LibraryDataModel() { Icon = "food",Title="Order on one tap",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. In facilisis nulla eu felis fringilla vulputate. Nullam porta eleifend lacinia. Donec at iaculis tellus." },
            };
        }
    }
}
