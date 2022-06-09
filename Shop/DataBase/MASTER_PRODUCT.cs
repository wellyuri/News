namespace Shop.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MASTER_PRODUCT
    {
        [Required]
        [StringLength(2)]
        public string GENRE_ID { get; set; }

        [Required]
        [StringLength(2)]
        public string CATEGORY_ID { get; set; }

        [Key]
        public int PRODUCT_ID { get; set; }

        [StringLength(100)]
        public string PRODUCT_NAME { get; set; }

        [StringLength(100)]
        public string AUTHOR { get; set; }

        [StringLength(100)]
        public string MAGAZINE_NAME { get; set; }

        [StringLength(100)]
        public string PUBLISHER { get; set; }

        [StringLength(100)]
        public string PRICE { get; set; }

        [StringLength(100)]
        public string CHARACTER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? REGISTER_DATE { get; set; }

        [StringLength(10)]
        public string REGISTER_USER_ID { get; set; }

        [StringLength(10)]
        public string REFER_USER_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? REFER_DATE { get; set; }
    }
}
