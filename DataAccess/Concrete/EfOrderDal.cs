using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, CreateAnOrderContext>, IOrderDal
    {
        //public List<OrdersDetailDto> AddOrdersDetails()
        //{
        //    using (CreateAnOrderContext context = new CreateAnOrderContext())
        //    {
        //        var result = from o in context.Orders
        //                     join p in context.Products
        //                     on o.Id equals p.Id
        //                     select new OrdersDetailDto
        //                     {
        //                         CompanyName=o.CompanyName,
        //                         OrderDate=o.OrderDate,
        //                         ProductName=p.ProductName,
        //                         StockQty=p.StockQty,
        //                         Price=p.Price
        //                     };

        //        return result.ToList();
        //    }
        //}
    }
}
