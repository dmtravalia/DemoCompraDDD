using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoCompra.Domain.Core.Interfaces
{
    public interface IUnitOfWork
    {
        int Commit();
    }
}
