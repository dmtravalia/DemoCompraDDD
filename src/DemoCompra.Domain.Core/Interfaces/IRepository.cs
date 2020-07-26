using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCompra.Domain.Core.Interfaces
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
