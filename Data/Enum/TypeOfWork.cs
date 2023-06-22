using System.ComponentModel.DataAnnotations;

namespace PermitToWorkSystem.Data.Enum
{
    public enum TypeOfWork
    {

        Excavation,
        [Display(Name = "Road Repair")]
        Road_Repair,
        [Display(Name = "Bridge Construction")]
        Bridge_Construction
    }
}
