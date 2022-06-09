using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop.DataBase;
using Shop.Models;

namespace Shop.Controllers
{
    public class SearchController : Controller
    {
        
        public ActionResult Index()
        {

            List<Product> msList;
            using (var db = new ShopDB())
            {
                msList = db.MASTER_PRODUCT
                .Join(db.GENRE,p => p.GENRE_ID,g => g.GENRE_ID,(p,g) => new {p,g})
                .Join(db.MASTER_CATEGORY,mp => mp.p.CATEGORY_ID,mc => mc.CATEGORY_ID,(mp,mc) => new {mp,mc})
                .Select(x => new Product {
                    ProductId = x.mp.p.PRODUCT_ID,
                    ProductName = x.mp.p.PRODUCT_NAME,
                    CategoryId = x.mp.p.CATEGORY_ID,
                    CategoryName = x.mc.CATEGORY_NAME,
                    GenreName = x.mp.g.GENRE_NAME,
                    Character = x.mp.p.CHARACTER,
                    MaxPlayer = x.mp.p.MAX_PLAYER,
                    AgeLimit = x.mp.p.AGE_LIMIT,
                    Price = x.mp.p.PRICE
                })
                .ToList();
            }
            return View(msList);
        } 
        public ActionResult Result(string genreId)
        {
           
            List<Product> productList;
            
            using (var db = new ShopDB())
            {
                productList = db.MASTER_PRODUCT
                    .Join(db.GENRE,p => p.GENRE_ID,g => g.GENRE_ID,(p,g) => new { p,g})
                    .Join(db.MASTER_CATEGORY,mp => mp.p.CATEGORY_ID,c => c.CATEGORY_ID,(mp,c) => new {mp,c})
                    .Where(p => p.mp.p.GENRE_ID == genreId)
                    .Select(x => new Product {
                        ProductId = x.mp.p.PRODUCT_ID,
                        ProductName = x.mp.p.PRODUCT_NAME,
                        CategoryId = x.mp.p.CATEGORY_ID,
                        CategoryName = x.c.CATEGORY_NAME,
                        GenreName = x.mp.g.GENRE_NAME,
                        Character = x.mp.p.CHARACTER,
                        MaxPlayer = x.mp.p.MAX_PLAYER,
                        AgeLimit = x.mp.p.AGE_LIMIT,
                        Price = x.mp.p.PRICE
                    })
                    .ToList();

            }
            return View(productList);
        }
   
    }
}