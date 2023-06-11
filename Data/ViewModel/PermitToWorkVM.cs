using System.ComponentModel.DataAnnotations;

namespace PermitToWorkSystem.Data.ViewModel
{
    public class PermitToWorkVM
    {
        [Key]
        public int PermitID { get; set; }
        [Required(ErrorMessage = "This fields is Required")]
        [Display(Name = "Facility/Project")]
        public string Project { get; set; }
        [Required(ErrorMessage = "This fields is Required")]
        [Display(Name = "Physical Location Of Work")]
        public string LocationOfWork { get; set; }
        [Required(ErrorMessage = "This fields is Required")]
        [Display(Name = "Plant/Equipment Description")]
        public string EquipmentDescription { get; set; }
        [Required(ErrorMessage = "This fields is Required")]
        [Display(Name = "Permit Applicant")]
        public string Permit_Applicant { get; set; }

        public string Company { get; set; }

        [Required]
        [Display(Name = "JSA NO")]
        public string JSA_NO { get; set; }
        [Required]
        [Display(Name = "Description of work")]
        public string Description_Of_Work { get; set; }
        [Required]
        public string Duration_Of_Work { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Start Time")]
        public TimeSpan StartTime { get; set; }
        [Display(Name = "End Time")]
        public TimeSpan EndTime { get; set; }

        [Required]
        [Display(Name = "Tools/Equipment to be used")]
        public string Tools_Equipmet { get; set; }
        [Required (ErrorMessage ="Email valid email address is required")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
    }
}

