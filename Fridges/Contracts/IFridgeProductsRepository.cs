using System;
using System.Collections.Generic;
using Entities.Models;

namespace Contracts
{
    public interface IFridgeProductsRepository
    {
        IEnumerable<FridgeProducts> GetAllFridgeProducts(bool trackChanges);
        FridgeProducts GetFridgeProduct(Guid fProductId, bool trackChanges);
    }
}