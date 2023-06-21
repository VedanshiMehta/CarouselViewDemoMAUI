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
    public partial class GetProductViewModel :ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<string> _productCategory;
        [ObservableProperty]
        private ObservableCollection<Product> _productItems;
        [ObservableProperty]
        private string _selectedItem;

        [ObservableProperty]
        private Product _product;
        [ObservableProperty]
        private Product _previousProduct;

        private ProductModel _productModel;
        public GetProductViewModel()
        {
            _productModel = new ProductModel();
            _ = GetProductListAsync();
        }

        private async Task GetProductListAsync()
        {
            await _productModel.GetProductCategoryList();
            ProductCategory = _productModel.ProductsCategoryList;
            SelectedItem = _productModel.SelectedProduct;
        }

        [RelayCommand]
        public async Task GetProductItemListAsync()
        {
            _productModel.SelectedProduct = SelectedItem;
            await _productModel.GetProductCategoryList();
            ProductItems = _productModel.ProductsItemList;
        }

        [RelayCommand]
        public void CurrentSelectedProduct(Product product)
        {
            if (product != null)
            {
                if (PreviousProduct != null)
                {
                    PreviousProduct.BackgroundColor = Colors.White;
                }

                PreviousProduct = Product;
                Product = product;
                Product.BackgroundColor = Colors.SkyBlue; 
            }
            
        }
    }
}
