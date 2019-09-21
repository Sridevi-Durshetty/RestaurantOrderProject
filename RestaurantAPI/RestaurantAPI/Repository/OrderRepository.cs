using RestaurantAPI.DB;
using RestaurantAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace RestaurantAPI.Repository
{
    public class OrderRepository
    {
        private RestaurantDBContext objRestaurantContext = new RestaurantDBContext();

        /// <summary>
        /// Default connected to SQL DB
        /// </summary>
        public OrderRepository() { }

        public IEnumerable<Order> GetOrders()
        {
            return objRestaurantContext.orderEntity;
        }

        public Order GetOrderById(int orderid)
        {
            return objRestaurantContext.orderEntity.Find(orderid);
        }

        public bool CreateOrder(Order order)
        {
            bool isCreated = false;
            objRestaurantContext.orderEntity.Add(order);
            try
            {
                objRestaurantContext.SaveChanges();
                isCreated = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);               
            }
            return isCreated;
        }

        public bool UpdateOrder(Order order)
        {           
            bool isUpdated = false;
            objRestaurantContext.Entry(order).State = EntityState.Modified;
            try
            {
                objRestaurantContext.SaveChanges();
                isUpdated = true;
            }
            catch (DbUpdateConcurrencyException exDbupdate)
            {
                if (!OrderExists(order.OrderId))
                {
                    Console.WriteLine("Order not found");
                }
                else
                {
                   Console.WriteLine(exDbupdate);
                }
                
            }
            return isUpdated;
        }

        public Order DeleteOrder(int orderid)
        {            
            Order order = objRestaurantContext.orderEntity.Find(orderid);
            if (order == null)
            {
                return null;
            }

            objRestaurantContext.orderEntity.Remove(order);
            objRestaurantContext.SaveChanges();
            return order;

        }

        public void OrderDispose()
        {
            objRestaurantContext.Dispose();
        }

        private bool OrderExists(int id)
        {
            return objRestaurantContext.custEntity.Count(e => e.CustomerId == id) > 0;
        }


    }
}