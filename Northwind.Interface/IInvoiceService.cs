using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface IInvoiceService : IGenericService<Invoice, DtoInvoice>
    {
        IQueryable<DtoInvoice> GetTotalReport();
    }
}
