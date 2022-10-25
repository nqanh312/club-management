using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetOrderDetails();
        OrderDetail GetOrderDetailByID(int orderId, int productId);
        void InsertOrderDetail(OrderDetail orderDetail);
        void DeleteOrderDetail(int orderId, int productId);
        void UpdateOrderDetail(OrderDetail orderDetail);

    }
}
