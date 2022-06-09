namespace Shop.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GENRE")]
    public partial class GENRE
    {
        [Key]
        [StringLength(2)]
        public string GENRE_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string GENRE_NAME { get; set; }
    }
}
