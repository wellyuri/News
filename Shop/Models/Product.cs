using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Product
    {
        /// <summary>
        /// プロダクトID
        /// </summary>
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string GenreName { get; set; }

        public string CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Character { get; set; }

        public string MagazineName { get; set; }

        public string Publisher { get; set; }

        public string Price { get; set; }


    }
}