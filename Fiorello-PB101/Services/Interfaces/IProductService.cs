﻿using Fiorello_PB101.Models;
using Fiorello_PB101.ViewModels.Products;

namespace Fiorello_PB101.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllWIthImageAsync();


        Task<Product> GetByIdWithAllDatasAsync(int id);

        Task<Product> GetByIdAsync(int id);

        Task<IEnumerable<Product>> GetAllAsync();

        IEnumerable<ProductVM> GetMappedDatas(IEnumerable<Product> products);


        Task<IEnumerable<Product>> GetAllPaginateAsync(int page, int take);

        Task<int> GetCountAsync();

    }
}