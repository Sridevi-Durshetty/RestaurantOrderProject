using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using RestaurantAPI.DB;
using RestaurantAPI.Models;
using RestaurantAPI.Repository;

namespace RestaurantAPI.Controllers
{
    [RoutePrefix("api/item")]
    public class ItemController : ApiController
    {
        ItemRepository objItemRepo = new ItemRepository();

        // GET: api/item
        public IHttpActionResult GetItems()
        {
            return Content(HttpStatusCode.OK, objItemRepo.GetItems());
        }

        // GET: api/customer/5
        [ResponseType(typeof(Customer))]
        public IHttpActionResult GetItemById(int id)
        {
            Item item = objItemRepo.GetItemById(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                objItemRepo.ItemDispose();
            }
            base.Dispose(disposing);
        }
    }
}