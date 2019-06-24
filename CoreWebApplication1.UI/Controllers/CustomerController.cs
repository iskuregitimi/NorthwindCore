using CoreWebApplication1.UI.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApplication1.UI.Controllers
{
    public class CustomerController:Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Customer> customerList = new List<Customer>();
            customerList = HttpHelper.GetData<List<Customer>>("http://localhost:8308/", "api/Customer/ListCustomer", Method.GET);
            return View(customerList);
        }



    }
}
