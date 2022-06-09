namespace Shop.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOGIN")]
    public partial class LOGIN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NO { get; set; }

        public DateTime LOGIN_DATE { get; set; }

        [StringLength(10)]
        public string USER_ID { get; set; }
    }
}
