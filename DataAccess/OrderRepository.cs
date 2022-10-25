using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOrder(int orderId) => OrderDAO.Instance.Remove(orderId);

        public IEnumerable<Order> GetOrder() => OrderDAO.Instance.GetOrderList();


        public Order GetOrderByID(int orderId) => OrderDAO.Instance.GetOrderByID(orderId);

        public void InsertOrder(Order order) => OrderDAO.Instance.AddNew(order);


        public void UpdateOrder(Order order) => OrderDAO.Instance.Update(order);
        
    }
}
