using System.Dynamic;
using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IFridgeModelRepository _fridgeModel;
        private IFridgeRepository _fridge;
        private IProductsRepository _products;
        private IFridgeProductsRepository _fridgeProducts;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IFridgeModelRepository fridgeModel
        {
            get
            {
                if(_fridgeModel == null)
                {
                    _fridgeModel = new FridgeModelRepository(_repositoryContext);
                }

                return _fridgeModel;
            }
        }

        public IFridgeRepository fridge
        {
            get
            {
                if (_fridge == null)
                {
                    _fridge = new FridgeRepository(_repositoryContext);
                }

                return _fridge;
            }
        }

        public IProductsRepository products
        {
            get
            {
                if (_products == null)
                {
                    _products = new ProductsRepository(_repositoryContext);
                }

                return _products;
            }
        }

        public IFridgeProductsRepository fridgeProducts
        {
            get
            {
                if (_fridgeProducts == null)
                {
                    _fridgeProducts = new FridgeProductsRepository(_repositoryContext);
                }

                return _fridgeProducts;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}