using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRentalApp.Models;
using MovieRentalApp.ViewModel;

namespace MovieRentalApp.Controllers
{
    public class CustomerController : Controller
    {
        
        public CustomerController() { 
            
        }
        // GET: Customer
        public ActionResult Customers()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int? id) 
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null) {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }

        private IEnumerable<Customers> GetCustomers()
        {
            return new List<Customers> {
                 new Customers { Id = 1, Name = "Dheeraj" },
                new Customers { Id = 2, Name = "Sunny" },
                new Customers { Id = 3, Name = "Oshin" }
            };
        }
    }
}