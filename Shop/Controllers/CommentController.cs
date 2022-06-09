using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop.DataBase;
using Shop.Models;

namespace Shop.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment

        public ActionResult Index(int productId)
        {
            IEnumerable<Comment> commentList;
            using (var db = new ShopDB())
            {
                commentList = db.PRODUCT_COMMENT
                    .Join(db.GENRE, c => c.GENRE_ID, g => g.GENRE_ID, (c, g) => new { c, g })
                    .Join(db.MASTER_CATEGORY, com => com.c.CATEGORY_ID, mc => mc.CATEGORY_ID, (com, mc) => new { com, mc })
                    .Join(db.MASTER_PRODUCT,comm => comm.com.c.PRODUCT_ID,p => p.PRODUCT_ID,(comm,p) => new {comm,p})
                    .Where(p => p.p.PRODUCT_ID==productId)
                    .Select(x => new Comment{
                        GenreId = x.comm.com.c.GENRE_ID,
                        GenreName = x.comm.com.g.GENRE_NAME,
                        CategoryId = x.p.CATEGORY_ID,
                        CategoryName = x.comm.mc.CATEGORY_NAME,
                        ProductId = x.p.PRODUCT_ID,
                        ProductName = x.p.PRODUCT_NAME,
                        CommentId = x.comm.com.c.COMMENT_NO,
                        Contents = x.comm.com.c.PRODUCT_COMMENT1
                      })
                    .ToList();
            }
            foreach (var c in commentList) {
                if (productId.Equals(c.ProductId))
                {
                    return View(commentList);
                }
            }
            return RedirectToAction("Index","Search");
        }
           
    }
}