using GalatasarayShop.Business.Types;
using GalatasarayShop.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalatasarayShop.Business.Services
{
    public interface IProductService
    {
        ServiceMessage AddProduct(ProductDto product);

        List<ProductDto> GetProducts(int? categoryId = null);

        ProductDto GetProductById(int id);

        void EditProduct(ProductDto product);

        void DeleteProduct(int id);
    }
}
