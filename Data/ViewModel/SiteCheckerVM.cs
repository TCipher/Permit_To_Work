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
        public bool NightWork { get; set; }
        public string JSA { get; set; }
        public string SpecialRequirements { get; set; }
        public string GasTesting { get; set; }
        public string Time { get; set; }
        public double LEL { get; set; }
        public double O2 { get; set; }
        public double H2S { get; set; }
        public double CO { get; set; }
        public string Others { get; set; }
        public string InstrumentNumber { get; set; }
        public string GasTesterName { get; set; }


       

    }
}
