namespace DemoCompra.Domain.Core.Interfaces
{
    public interface IUnitOfWork
    {
        bool Commit();
    }
}
