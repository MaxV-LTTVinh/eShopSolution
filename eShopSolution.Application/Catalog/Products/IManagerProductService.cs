﻿using eShopSolution.Application.Catalog.DTO;
using eShopSolution.Application.Catalog.Products.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManagerProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductCreateRequest request);
        Task<int> Delete(int productId);
        Task<List<ProductViewModel>> GetAll ();
        Task<PageViewModel<ProductViewModel>> GetAllPaging (string keyword, int pageIndex, int pageSize);
    }
}