using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                }
                return instance;
            }
        }

        public IEnumerable<OrderDetail> GetOrderDetailList()
        {
            var orderDetails = new List<OrderDetail>();
            try
            {
                using var context = new myestoreContext();
                orderDetails = context.OrderDetails.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return orderDetails;
        }

        public OrderDetail GetOrderDetailByID(int orderId, int productID)
        {
            OrderDetail orderDetails = null;
            try
            {
                using var context = new myestoreContext();
                orderDetails = context.OrderDetails.SingleOrDefault(o => o.OrderId == orderId && o.ProductId== productID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return orderDetails;
        }

        public void AddNew(OrderDetail orderDetails)
        {
            try
            {
                OrderDetail _orderDetail = GetOrderDetailByID(orderDetails.OrderId, orderDetails.ProductId);
                if (_orderDetail == null)
                {
                    using var context = new myestoreContext();
                    context.OrderDetails.Add(orderDetails);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The OrderDetail is already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Update(OrderDetail orderDetails)
        {
            try
            {

                OrderDetail _order = GetOrderDetailByID( orderDetails.OrderId, orderDetails.ProductId);
                if (_order != null)
                {
                    using var context = new myestoreContext();
                    context.OrderDetails.Update(orderDetails);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The orderdetail does not already exist");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Remove(int orderId, int productId)
        {
            try
            {

                OrderDetail order = GetOrderDetailByID(orderId,productId);
                if (order != null)
                {
                    using var context = new myestoreContext();
                    context.OrderDetails.Remove(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The orderdetails does not already exist");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}

