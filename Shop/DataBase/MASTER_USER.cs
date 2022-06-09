namespace Shop.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MASTER_USER
    {
        [Key]
        [StringLength(10)]
        public string USER_ID { get; set; }

        [StringLength(10)]
        public string NAME_FAMILY { get; set; }

        [StringLength(10)]
        public string NAME_FIRST { get; set; }

        [StringLength(50)]
        public string KANA { get; set; }

        public double? AUTHORITY { get; set; }

        [Required]
        [StringLength(20)]
        public string PASSWORD { get; set; }

        public double? STATUS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? REGISTER_DATE { get; set; }

        [StringLength(10)]
        public string REGISTER_USER_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UPDATE_DATE { get; set; }
    }
}
