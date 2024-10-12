using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interface
{
    public interface IProductService
    {
        Task<bool> AddNewProduct(Product product, List<string> imagePaths);
        Task<bool> DeleteProduct(int id);
    }
}
