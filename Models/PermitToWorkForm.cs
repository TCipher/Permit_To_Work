using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PermitToWorkSystem.Models
{
    public class PermitToWorkForm
    {
        [Key]
        public int PermitID { get; set; }
        [Required]
        public string Project { get; set; }
        [Required]
        public string LocationOfWork { get; set; }
        [Required]
        public string EquipmentDescription { get; set; }
        [Required]
        public string Permit_Applicant { get; set; }
        [Required]
        public string Company { get; set; }

        [Required]
        public string JSA_NO { get; set; }
        [Required]
        public string Description_Of_Work { get; set; }
        [Required]
        public string Duration_Of_Work { get;set; }
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
        [Required]

        public TimeSpan StartTime { get; set; }
        [Required]
        public TimeSpan EndTime { get; set; }
        [Required]
        public string Tools_Equipmet { get; set; }

        public string EmailAddress { get; set; }
    }
}
