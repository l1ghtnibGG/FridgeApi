using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class FridgeProductsRepository : RepositoryBase<FridgeProducts>, IFridgeProductsRepository
    {
        public FridgeProductsRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<FridgeProducts> GetAllFridgeProducts(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(n => n.Id).ToList();

        public FridgeProducts GetFridgeProduct(Guid fProductId, bool trackChanges) =>
            FindCondition(n => n.Id.Equals(fProductId), trackChanges)
                .SingleOrDefault();
    }
}