using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Comment

    {
        public string GenreId { get; set; }

        public int ProductId { get; set; }

        public int CommentId { get; set; }

        public string Contents { get; set; }

        public string ProductName { get; set; }

        public string GenreName { get; set; }

        public string CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Character { get; set; }
    }
}