using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Exercises.Model
{
    public class LibraryModel
    {
       public ObservableCollection<LibraryDataModel> LibraryData { get; set; }
        public void GetLibraryData()
        {
            LibraryData = new ObservableCollection<LibraryDataModel>()
            {
                new LibraryDataModel() { Icon = "userLibrary",Title="Read & Learn Anywhere",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. In facilisis nulla eu felis fringilla vulputate. Nullam porta eleifend lacinia. Donec at iaculis tellus." },
                new LibraryDataModel() { Icon = "poetrybook",Title="Create your own Stories",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. In facilisis nulla eu felis fringilla vulputate. Nullam porta eleifend lacinia. Donec at iaculis tellus." },
                new LibraryDataModel() { Icon = "books",Title="Your favourite books",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. In facilisis nulla eu felis fringilla vulputate. Nullam porta eleifend lacinia. Donec at iaculis tellus." },
            };
        }
    }
}
