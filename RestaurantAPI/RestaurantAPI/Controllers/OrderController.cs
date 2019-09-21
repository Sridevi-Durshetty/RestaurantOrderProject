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
    public class OrderController : ApiController
    {
        private OrderRepository objOrderRepo = new OrderRepository();
        // GET: api/Order
        public IHttpActionResult Getorders()
        {
            return Content(HttpStatusCode.OK, objOrderRepo.GetOrders());
        }

        // GET: api/Order/5
        [ResponseType(typeof(Order))]
        public IHttpActionResult GetOrderById(int id)
        {
            Order order = objOrderRepo.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        // POST: api/Order
        [ResponseType(typeof(Order))]
        public IHttpActionResult PostOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (objOrderRepo.CreateOrder(order))
                return CreatedAtRoute("DefaultApi", new { id = order.OrderId }, order);
            else
                return BadRequest("Error while inserting");
        }

        // PUT: api/Order/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOrder(int id, Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != order.OrderId)
            {
                return BadRequest();
            }

            if (objOrderRepo.UpdateOrder(order))
                return StatusCode(HttpStatusCode.NoContent);
            else
                return NotFound();
        }

        // DELETE: api/Order/5
        [ResponseType(typeof(Order))]
        public IHttpActionResult DeleteOrder(int id)
        {
            Order order = objOrderRepo.DeleteOrder(id);
            if(order == null)
                return NotFound();
            else
                return Ok(order);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                objOrderRepo.OrderDispose();
            }
            base.Dispose(disposing);
        }
       
    }
}