namespace Shop.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER")]
    public partial class USER
    {
        [StringLength(10)]
        public string USER_ID { get; set; }

        [Key]
        [StringLength(10)]
        public string PASSWORD { get; set; }
    }
}
