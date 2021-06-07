namespace CodeFirstProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dersler")]
    public partial class Dersler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dersID { get; set; }

        [StringLength(100)]
        public string dersAd { get; set; }

        public int? bolumID { get; set; }
    }
}
