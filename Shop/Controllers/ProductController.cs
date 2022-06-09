using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop.Models;
using Shop.DataBase;


namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        
        public ActionResult Index()
        {
           
            List<LOGIN> loginList;
            using (var db = new ShopDB())
            {
                loginList = db.LOGIN.ToList();
            }
                return View(loginList);
        }

    }
}