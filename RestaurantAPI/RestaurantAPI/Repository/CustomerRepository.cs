﻿using RestaurantAPI.DB;
using RestaurantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantAPI.Repository
{
    public class CustomerRepository
    {
        private RestaurantDBContext objRestaurantContext = new RestaurantDBContext();

        /// <summary>
        /// Default connected to SQL DB
        /// </summary>
        public CustomerRepository() { }

        public IEnumerable<Customer> GetCustomers()
        {
            return objRestaurantContext.custEntity.Select(x => x);
        }

        public Customer GetCustomerById(int custid)
        {
            return objRestaurantContext.custEntity.Find(custid);
        }

        public void CustomerDispose()
        {
            objRestaurantContext.Dispose();
        }

        private bool ItemExists(int id)
        {
            return objRestaurantContext.custEntity.Count(e => e.CustomerId == id) > 0;
        }


    }
}