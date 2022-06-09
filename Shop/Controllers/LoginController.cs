using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Shop.DataBase;
using Shop.Models;

namespace Shop.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Check(string userId, string password)
        {

            var db = new ShopDB();
            var us = from u in db.MASTER_USER select u;
           

            foreach (var r in us)
            {
                Console.WriteLine("{0},{1}", r.USER_ID, r.PASSWORD);


                if (r.USER_ID.Equals(userId))
                {

                    if (r.PASSWORD.Equals(password))
                    {
                        //return true;
                        return RedirectToAction("Index", "Menu");
                    }
                    //return false; 
                }   
            }
            return RedirectToAction("Index", "Login");
        }

        }
    }



