namespace Shop.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MASTER_PRODUCT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string GENRE_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string CATEGORY_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string PRODUCT_ID { get; set; }

        [StringLength(100)]
        public string PRODUCT_NAME { get; set; }

        [StringLength(100)]
        public string CHARACTER { get; set; }

        [StringLength(100)]
        public string MAX_PLAYER { get; set; }

        [StringLength(100)]
        public string AGE_LIMIT { get; set; }

        [StringLength(100)]
        public string PRICE { get; set; }

        [StringLength(100)]
        public string MEMO { get; set; }

        public DateTime? REGISTER_DATE { get; set; }

        [StringLength(10)]
        public string REGISTER_USER_ID { get; set; }

        [StringLength(10)]
        public string REFER_USER_ID { get; set; }

        public DateTime? REFER_DATE { get; set; }
    }
}
