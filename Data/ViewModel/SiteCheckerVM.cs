using Microsoft.Build.Framework;
using PermitToWorkSystem.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace PermitToWorkSystem.Data.ViewModel
{
    public class SiteCheckerVM
    {
        [Required]
        public bool Isolation { get; set; }
        [Required]
        public string Bypass { get; set; }
        [Required]
        public string MOC { get; set; }
        [Required]
        public bool Access { get; set; }
        [Required]
        public bool Barricade { get; set; }
        [Required]
        public string CriticalLift { get; set; }
        [Required]
        public bool NightWork { get; set; }
        [Required]
        public string JSA { get; set; }
        [Required]
        public string SpecialRequirements { get; set; }
        [Required]
        public string GasTesting { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public double LEL { get; set; }
        [Required]
        public double O2 { get; set; }
        [Required]
        public double H2S { get; set; }
        [Required]
        public double CO { get; set; }
        [Required]
        public string Others { get; set; }
        [Required]
        public string InstrumentNumber { get; set; }
        [Required]
        public string GasTesterName { get; set; }


       

    }
}
