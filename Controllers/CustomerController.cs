using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRentalApp.Models;
using System.Data.Entity;

namespace MovieRentalApp.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        public CustomerController() { 
            _context = new ApplicationDbContext();
        }
        // GET: Customer
        public ActionResult Customers()
        {
            //var customers = GetCustomers();
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int? id) 
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null) {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }

        //private IEnumerable<Customers> GetCustomers()
        //{
        //    return new List<Customers> {
        //         new Customers { Id = 1, Name = "Dheeraj" },
        //        new Customers { Id = 2, Name = "Sunny" },
        //        new Customers { Id = 3, Name = "Oshin" }
        //    };
        //}
    }
}