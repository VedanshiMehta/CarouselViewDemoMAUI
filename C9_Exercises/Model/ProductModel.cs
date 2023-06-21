using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Exercises
{
    public partial class ProductModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<string> _productsCategoryList;
        [ObservableProperty]
        private ObservableCollection<Product> _productsItemList;
        [ObservableProperty]
        private string _selectedProduct;

        private GetProductEndPoint _endPoint;
        public ProductModel()
        {
            _endPoint = new GetProductEndPoint();
        }

        public async Task<Result> GetProductCategoryList()
        {
            if(CrossConnectivity.Current.IsConnected)
            {
                var response = await _endPoint.GetProductCategoryListAsync();
                if(response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var category= JsonConvert.DeserializeObject<List<string>>(data);
                    ProductsCategoryList = new ObservableCollection<string>(category);
                    if(SelectedProduct == null)
                    {
                        SelectedProduct = ProductsCategoryList.FirstOrDefault();
                    }
                    _endPoint.SelectedProduct = SelectedProduct;
                    var result = await _endPoint.GetSelectedProductAsync();
                    if(result.IsSuccessStatusCode)
                    {
                        var itemdata = await result.Content.ReadAsStringAsync();
                        var productItem = JsonConvert.DeserializeObject<GetCategoryResponse>(itemdata);
                        ProductsItemList = new ObservableCollection<Product>(productItem.Products);
                    }
                    return new Result()
                    {
                        IsSuccess = true,
                    };
                }
                else
                {
                    return new Result()
                    {
                        IsSuccess = false,
                        Message = "Something went wrong"
                    };
                }
            }
            else
            {
                return new Result()
                {
                    IsSuccess = false,
                    IsInternetError = true,
                    Message = "No Internet Connection"
                };
            }
        }
    }
}
