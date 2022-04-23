﻿using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext context) : base(context) //base: kalıtım aldığı yere gider
        {

        }
        public IQueryable<Employee> GetTotalReport()//:this() //const const a veri gondermek için kullanılır
        {
            return dbset.AsQueryable();
        }
    }
}
