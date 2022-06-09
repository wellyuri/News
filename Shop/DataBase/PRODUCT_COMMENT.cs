namespace Shop.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_COMMENT
    {
        [StringLength(2)]
        public string GENRE_ID { get; set; }

        [StringLength(2)]
        public string CATEGORY_ID { get; set; }

        public int? PRODUCT_ID { get; set; }

        [Key]
        public int COMMENT_NO { get; set; }

        [Column("PRODUCT_COMMENT")]
        [StringLength(1000)]
        public string PRODUCT_COMMENT1 { get; set; }

        [StringLength(10)]
        public string REGISTER_USER_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? REGISTER_DATE { get; set; }
    }
}
