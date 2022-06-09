using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop.DataBase;
using Shop.Models;

namespace Shop.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult Index(int productId)
        {
            List<Product> productList;

            using (var db = new ShopDB())
            {
                productList = db.MASTER_PRODUCT
                    .Join(db.GENRE, p => p.GENRE_ID, g => g.GENRE_ID, (p, g) => new { p, g })
                    .Join(db.MASTER_CATEGORY, mp => mp.p.CATEGORY_ID, c => c.CATEGORY_ID, (mp, c) => new { mp, c })
                    .Where(p => p.mp.p.PRODUCT_ID == productId)
                    .Select(x => new Product
                    {
                        ProductId = x.mp.p.PRODUCT_ID,
                        ProductName = x.mp.p.PRODUCT_NAME,
                        CategoryId = x.mp.p.CATEGORY_ID,
                        CategoryName = x.c.CATEGORY_NAME,
                        GenreName = x.mp.g.GENRE_NAME,
                        Character = x.mp.p.CHARACTER,
                        MagazineName = x.mp.p.MAGAZINE_NAME,
                        Publisher = x.mp.p.PUBLISHER,
                        Price = x.mp.p.PRICE
                    })
                    .ToList();
                foreach (var p in productList)
                {
                    if (productId.Equals(p.ProductId))
                    {
                        return View(productList);
                    }
                }
                return RedirectToAction("Index","Search");
            }
        }
    }
}