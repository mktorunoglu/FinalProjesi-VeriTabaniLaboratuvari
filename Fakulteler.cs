namespace CodeFirstProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Fakulteler")]
    public partial class Fakulteler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fakulteler()
        {
            Bolumlers = new HashSet<Bolumler>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fakulteID { get; set; }

        [StringLength(100)]
        public string fakulteAd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bolumler> Bolumlers { get; set; }
    }
}
