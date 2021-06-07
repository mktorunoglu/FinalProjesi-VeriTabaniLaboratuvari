namespace CodeFirstProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ogrenciler")]
    public partial class Ogrenciler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ogrenciID { get; set; }

        [StringLength(25)]
        public string ad { get; set; }

        [StringLength(25)]
        public string soyad { get; set; }

        public int? bolumID { get; set; }
    }
}
