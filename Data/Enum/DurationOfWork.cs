using System.ComponentModel.DataAnnotations;

namespace PermitToWorkSystem.Data.Enum
{
    public enum DurationOfWork
    {
        [Display(Name = "1 hour")]
        OneHour,
        [Display(Name = "2 hours")]
        TwoHours,
        [Display(Name = "3 hour")]
        ThreeHours,
        [Display(Name = "4 hours")]
        FourHours,
        [Display(Name = "5 hours")]
        FiveHours,
        [Display(Name = "6 hours")]
        SixHours,

    }
}