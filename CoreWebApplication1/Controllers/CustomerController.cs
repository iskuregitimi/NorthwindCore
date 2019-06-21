using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApplication1.DataBase;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        NorthwindContext _northwindContext; 
        public CustomerController(NorthwindContext northwindContext)
        {
            _northwindContext = northwindContext;
        }

        [HttpGet]
        public List<Customer> List()
        {            
            var result= _northwindContext.Customers.ToList();
            return result;
        }
    }
}