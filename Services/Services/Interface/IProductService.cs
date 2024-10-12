﻿using Repository.Models;
using Services.ModelView;
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

        Task<List<ProductDtoResponse>> GetAllProducts(int CategoryId);

        Task<ProductDtoResponse> GetProductByID(int id);

        Task<int> StatusProduct(int id);

        Task<List<ProductDtoResponse>> Search(string searchInput);
    }
}
