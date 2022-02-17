using System;
using System.Collections.Generic;
using Entities.Models;

namespace Contracts
{
    public interface IFridgeRepository
    {
        IEnumerable<Fridge> GetAllFridges(bool trackChanges);
        Fridge GetFridge(Guid fridgeId, bool trackChanges);
    }
}