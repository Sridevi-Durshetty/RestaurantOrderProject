using RestaurantAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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

        [HttpGet]
        public IHttpActionResult Message()
        {
            return Content(HttpStatusCode.OK, objCustRepo.GetCustomers());
        }
    }
}
