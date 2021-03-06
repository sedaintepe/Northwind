using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface ISupplierService : IGenericService<Supplier, DtoSupplier>
    {
        IQueryable<DtoSupplier> GetTotalReport();
    }
}
