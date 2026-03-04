namespace Clinic.AppModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Genders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Genders()
        {
            Patients = new HashSet<Patients>();
        }

        [Key]
        public int IdGender { get; set; }

        [Required]
        [StringLength(50)]
        public string GenderName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patients> Patients { get; set; }
    }
}
