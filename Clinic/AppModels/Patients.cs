namespace Clinic.AppModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Patients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patients()
        {
            Visits = new HashSet<Visits>();
        }

        [Key]
        public int IdPatient { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        public int GenderId { get; set; }

        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(50)]
        public string InsurancePolicy { get; set; }

        [Column(TypeName = "date")]
        public DateTime FluragrafiaDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime DIspanserizaciaDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Height { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Weight { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? InvalidnostGroup { get; set; }

        [Column(TypeName = "date")]
        public DateTime? InvalidnostGroupDate { get; set; }

        [StringLength(50)]
        public string Photo { get; set; }

        public virtual Genders Genders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visits> Visits { get; set; }
    }
}
