using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class FridgeRepository : RepositoryBase<Fridge>, IFridgeRepository
    {
        public FridgeRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Fridge> GetAllFridges(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(n => n.Name).ToList();

        public Fridge GetFridge(Guid fridgeId, bool trackChanges) =>
            FindCondition(c => c.Id.Equals(fridgeId), trackChanges)
                .SingleOrDefault();
    }
}