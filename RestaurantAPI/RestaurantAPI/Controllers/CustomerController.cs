using RestaurantAPI.Models;
using RestaurantAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace RestaurantAPI.Controllers
{
    [RoutePrefix("api/customer")]
    // [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CustomerController : ApiController
    {
        CustomerRepository objCustRepo = new CustomerRepository();
        /// <summary>
        /// Default Connect to SQL DB
        /// </summary>
        public CustomerController() { }

        // GET: api/customer
        public IHttpActionResult GetCustomers()
        {
            return Content(HttpStatusCode.OK, objCustRepo.GetCustomers());
        }

        // GET: api/customer/5
        [ResponseType(typeof(Customer))]
        public IHttpActionResult GetcustomerById(int id)
        {
            Customer cust = objCustRepo.GetCustomerById(id);
            if (cust == null)
            {
                return NotFound();
            }

            return Ok(cust);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                objCustRepo.CustomerDispose();
            }
            base.Dispose(disposing);
        }
    }
}
