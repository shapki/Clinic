namespace Clinic.AppModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Visits
    {
        [Key]
        public int IdVisit { get; set; }

        [Column(TypeName = "date")]
        public DateTime VisitDate { get; set; }

        public int PatientId { get; set; }

        public int MedicId { get; set; }

        public virtual Medics Medics { get; set; }

        public virtual Patients Patients { get; set; }
    }
}
