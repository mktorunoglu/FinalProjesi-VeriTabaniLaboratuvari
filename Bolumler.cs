namespace CodeFirstProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bolumler")]
    public partial class Bolumler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int bolumID { get; set; }

        [StringLength(100)]
        public string bolumAd { get; set; }

        public int? fakulteID { get; set; }
    }
}
