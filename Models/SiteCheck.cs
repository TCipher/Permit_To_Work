using MessagePack;

namespace PermitToWorkSystem.Models
{
    public class SiteCheck
    {
        public int Id { get; set; }
        public bool Isolation { get; set; }
        public string Bypass { get; set; }
        public string MOC { get; set; }
        public bool Access { get; set; }
        public bool Barricade { get; set; }
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
