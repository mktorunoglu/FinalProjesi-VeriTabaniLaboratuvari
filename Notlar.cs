namespace CodeFirstProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notlar")]
    public partial class Notlar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int notID { get; set; }

        public int? ogrenciID { get; set; }

        public int? dersID { get; set; }

        [StringLength(9)]
        public string yil { get; set; }

        [StringLength(5)]
        public string yariyil { get; set; }

        public int? vize { get; set; }

        public int? final { get; set; }
    }
}
