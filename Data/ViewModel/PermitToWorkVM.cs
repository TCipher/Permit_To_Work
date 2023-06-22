using PermitToWorkSystem.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace PermitToWorkSystem.Data.ViewModel
{
    public class PermitToWorkVM
    {
        [Key]
        public int PermitID { get; set; }
        [Required(ErrorMessage = "Last Name Is Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "First Name is Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Project Name Is Required")]
        [Display(Name = "Project Name")]
        public string Project_Name { get; set; }
        [Required(ErrorMessage = "JSA NO. is required")]
        [Display(Name = "JSA NO")]
        public string JSANO { get; set; }

        [Required(ErrorMessage = "Company Name is required")]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Company Address is required")]
        [Display(Name = "Company Address")]
        public string CompanyAddress { get; set; }
        [Required(ErrorMessage = "Duration Of Work is Required")]
        [Display(Name = "Duration Of Work")]
        public DurationOfWork Duration_Of_Work { get; set; }
        
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
        [Display(Name = "Type Of Work")]
        public TypeOfWork Type_OF_Work { get; set; }
        [Required (ErrorMessage ="This field cannot be empty")]
        [Display(Name ="Equipment Description")]
        public string Equipment_Description { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        [Display(Name = "Equipment To be used")]
        public string Equipment_To_Be_Used { get; set; }

        [Required(ErrorMessage ="you must consent to the form")]
        [Display(Name ="I understand and agree to permit conditions")]
        public bool Accent { get; set; }


    }
}

