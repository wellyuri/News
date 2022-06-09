namespace Shop.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MASTER_CATEGORY
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string GENRE_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string CATEGORY_ID { get; set; }

        [StringLength(100)]
        public string CATEGORY_NAME { get; set; }
    }
}
