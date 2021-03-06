using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Dal.Abstract
{
    public interface IOrderRepository 
    {
        IQueryable<Order> GetTotalReport();
    }
}

