using PermitToWorkSystem.Data.Enum;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PermitToWorkSystem.Models
{
    public class PermitToWorkForm
    {
        [Key]
        public int PermitID { get; set; }
        
        public string LastName { get; set; }
        
        public string FirstName { get; set; }
        
        public string ProjectName { get; set; }
        
        public string JSANO { get; set; }
        
        public string CompanyName { get; set; }

        
        public string CompanyAddress { get; set; }
        
        public DurationOfWork Duration_Of_Work { get; set; }
        
        public TypeOfWork Type_Of_Work { get; set; }
        public DateTime StartDate { get; set; }

        
        public DateTime EndDate { get; set; }
        

        public TimeSpan StartTime { get; set; }
        
        public TimeSpan EndTime { get; set; }
        
        public string Equipment_To_Be_Used { get; set; }
         
        public string Equipment_Description { get; set; }

        public bool Accent { get; set; }    
    }
}
