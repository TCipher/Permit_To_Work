using PermitToWorkSystem.Data.Base;
using PermitToWorkSystem.Data.IServices;
using PermitToWorkSystem.Data.ViewModel;
using PermitToWorkSystem.Models;

namespace PermitToWorkSystem.Data.Service
{

    public class SiteCheckerService : EntityBaseRepository<SiteCheck>, ISiteCheckerService
    {
        private readonly AppDbContext _context;
        public SiteCheckerService(AppDbContext context):base(context)
        {
            _context = context; 
        }
        public async Task<SiteCheck> AddSiteCheckData(SiteCheckerVM data)
        {
            var siteCheckerResult = new SiteCheck()
            {
                Isolation = data.Isolation,
                Bypass = data.Bypass,
                LEL = data.LEL,
                CriticalLift = data.CriticalLift,
                Access = data.Access,
                Barricade = data.Barricade,
                CO = data.CO,
                GasTesterName = data.GasTesterName,
                H2S = data.H2S,
                O2 = data.O2,
                InstrumentNumber = data.InstrumentNumber,
                GasTesting = data.GasTesting,
                JSA = data.JSA,
                MOC = data.MOC,
                NightWork = data.NightWork,
                SpecialRequirements = data.SpecialRequirements,
                Others = data.Others,
                Time = data.Time
            };
            await _context.siteChecker.AddAsync(siteCheckerResult);
            await _context.SaveChangesAsync();
            return siteCheckerResult;
        }

    }
}
