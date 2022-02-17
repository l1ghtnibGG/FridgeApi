using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class ProductsRepository : RepositoryBase<Products>, IProductsRepository
    {
        public ProductsRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext)
        {
        }

        public IEnumerable<Products> GetAllProducts(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(n => n.Name)
                .ToList();

        public Products GetProduct(Guid fProductId, bool trackChanges) =>
            FindCondition(n => n.Id.Equals(fProductId), trackChanges)
                .SingleOrDefault();
    }
}