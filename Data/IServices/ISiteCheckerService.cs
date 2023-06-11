using PermitToWorkSystem.Data.Base;
using PermitToWorkSystem.Data.ViewModel;
using PermitToWorkSystem.Models;

namespace PermitToWorkSystem.Data.IServices
{
    public interface ISiteCheckerService : IEntityBaseRepository<SiteCheck>
    {

      
        Task<SiteCheck> AddSiteCheckData(SiteCheckerVM data);

    }
}