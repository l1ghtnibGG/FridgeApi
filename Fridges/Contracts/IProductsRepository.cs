using System;
using System.Collections.Generic;
using Entities.Models;

namespace Contracts
{
    public interface IProductsRepository
    {
        IEnumerable<Products> GetAllProducts(bool trackChanges);
        Products GetProduct(Guid productId, bool trackChanges);
    }
}