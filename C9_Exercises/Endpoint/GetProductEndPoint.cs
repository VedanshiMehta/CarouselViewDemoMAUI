using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Exercises
{
    public  class GetProductEndPoint
    {
        public string SelectedProduct { get; set; }

        public async Task<HttpResponseMessage> GetProductCategoryListAsync()
        {
            return await RestService.For<IProductApi>("https://dummyjson.com/products").GetCategoryList();
        }
        public async Task<HttpResponseMessage> GetSelectedProductAsync()
        {
            return await RestService.For<IProductApi>("https://dummyjson.com/products").GetProductItemList(SelectedProduct);
        }
    }
}
