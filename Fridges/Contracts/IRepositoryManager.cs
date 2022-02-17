namespace Contracts
{
    public interface IRepositoryManager
    {
        IFridgeModelRepository fridgeModel { get; }
        IFridgeRepository fridge { get; }
        IProductsRepository products { get; }
        IFridgeProductsRepository fridgeProducts { get; }
        void Save();
    }
}