using RestaurantAPI.DB;
using RestaurantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantAPI.Repository
{
    public class ItemRepository
    {
        private RestaurantDBContext objRestaurantContext = new RestaurantDBContext();

        /// <summary>
        /// Default connected to SQL DB
        /// </summary>
        public ItemRepository() { }

        public IEnumerable<Item> GetItems()
        {
            return objRestaurantContext.itemEntity;
        }

        public Item GetItemById(int itemid)
        {
            return objRestaurantContext.itemEntity.Find(itemid);
        }

        public void ItemDispose()
        {
            objRestaurantContext.Dispose();
        }

        private bool ItemExists(int id)
        {
            return objRestaurantContext.itemEntity.Count(e => e.ItemId == id) > 0;
        }


    }
}