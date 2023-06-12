using PermitToWorkSystem.Data.Base;
using PermitToWorkSystem.Data.Service;
using PermitToWorkSystem.Data.ViewModel;
using PermitToWorkSystem.Models;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace PermitToWorkSystem.Data.IServices
{
    public interface IPermitToWorkService : IEntityBaseRepository<PermitToWorkForm>
    {
        Task<PermitToWorkForm> AddPermitToWorkAsync(PermitToWorkVM data);
        Task<PermitToWorkForm> GetApplicantByIdAsync(int id);
       // Task<PermitToWorkForm> Approval(string model);
       

        Task<IEnumerable<PermitToWorkForm>> GetAllAsync();




    }
}
