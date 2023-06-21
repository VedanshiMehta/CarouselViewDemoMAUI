using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Exercises
{
    public interface IProductApi
    {
        [Get("/categories")]
        Task<HttpResponseMessage> GetCategoryList();
        [Get("/category/{category}")]
        Task<HttpResponseMessage> GetProductItemList(string category);
    }
}
