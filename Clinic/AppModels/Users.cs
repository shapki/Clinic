namespace Clinic.AppModels
{
    using System.ComponentModel.DataAnnotations;

    public partial class Users
    {
        [Key]
        public int IdUser { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }
    }
}
