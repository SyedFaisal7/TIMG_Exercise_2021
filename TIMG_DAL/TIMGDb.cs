using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIMG_BOL;
using System.Threading.Tasks;

namespace TIMG_DAL
{
    public interface ITIMGDb
    {
        IQueryable<Product> GetAllProducts();

        IQueryable<Product> GetProductbyProductCode(string ProductCode);
        IQueryable<Client> GetAllClients();

        IQueryable<Client> GetClientbyClientId(int ClientId);
        IQueryable<Order> GetAllOrders();

        IQueryable<Order> GetOrderbyOrderId(int OrderId);
        IQueryable<OrderItem> GetAllOrderItem();

        IQueryable<OrderItem> GetOrderItembyOrderId(int OrderId);
    }

    public class TIMGDB : ITIMGDb
    {

        public TIMGDbContext context;
        public TIMGDB(TIMGDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Client> GetAllClients()
        {
            throw new NotImplementedException();
        }

        public IQueryable<OrderItem> GetAllOrderItem()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> GetAllOrders()
        {
            //throw new NotImplementedException();
            return context.Order.Include(x => x.OrderItems)
                                .Select(x => new Order()
                                {
                                    OrderId = x.OrderId,
                                    ClientId = x.ClientId,
                                    ClientName = x.Client.ClientName,
                                    OrderDate = x.OrderDate,
                                    GST = x.GST,
                                    Total = x.Total,
                                    OrderItems = x.OrderItems.Where(y => y.OrderId == x.OrderId).ToList()
                                });
                                
        }

        public IQueryable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Client> GetClientbyClientId(int ClientId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> GetOrderbyOrderId(int OrderId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<OrderItem> GetOrderItembyOrderId(int OrderId)
        {
            return context.OrderItem.Where(x => x.OrderId == OrderId);
        }

        public IQueryable<OrderItem> GetOrderItembyOrderItemId(int ProductCode)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetProductbyProductCode(string ProductCode)
        {
            throw new NotImplementedException();
        }
    }
}
