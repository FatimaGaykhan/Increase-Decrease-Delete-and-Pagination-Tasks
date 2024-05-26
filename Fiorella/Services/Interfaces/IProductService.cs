﻿using System;
using Fiorella.Models;
using Fiorella.ViewModels.Products;

namespace Fiorella.Services.Interfaces
{
	public interface IProductService
	{
		Task<IEnumerable<Product>> GetAllWithImagesAsync();
		Task<Product> GetByIdWithAllDatas(int id);
		Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<Product>> GetAllPaginateAsync(int page, int take);
        IEnumerable<ProductVM> GetMappedDatas(IEnumerable<Product> products);
        Task<int> GetCountAsync();
    }
}

