namespace Shop.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMENT")]
    public partial class COMMENT
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

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string COMMENT_ID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string COMMENT_CONTENTS { get; set; }
    }
}
