using Microsoft.EntityFrameworkCore;
using PermitToWorkSystem.Data.Base;
using PermitToWorkSystem.Data.IServices;
using PermitToWorkSystem.Data.ViewModel;
using PermitToWorkSystem.Models;

namespace PermitToWorkSystem.Data.Service
{
    public class PermitToWorkService:EntityBaseRepository<PermitToWorkForm>, IPermitToWorkService
    {
        private readonly AppDbContext _context;
        public PermitToWorkService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<PermitToWorkForm> AddPermitToWorkAsync(PermitToWorkVM data)
        {
            var newPermit = new PermitToWorkForm()
            {
                Project = data.Project,
                LocationOfWork = data.LocationOfWork,
                EquipmentDescription = data.EquipmentDescription,
                Permit_Applicant = data.Permit_Applicant,
                Company = data.Company,
                JSA_NO = data.JSA_NO,
                Description_Of_Work = data.Description_Of_Work,
                Duration_Of_Work = data.Duration_Of_Work,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                StartTime = data.StartTime,
                EndTime = data.EndTime,
                Tools_Equipmet = data.Tools_Equipmet,
                EmailAddress = data.EmailAddress
                
            };
            await _context.permitToWorkForm.AddAsync(newPermit);
            await _context.SaveChangesAsync();
            return newPermit;
        }

        //public Task<PermitToWorkForm> Approval(string model)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<PermitToWorkForm> GetApplicantByIdAsync(int id)
        {
            var permitToWork = await _context.permitToWorkForm.FirstOrDefaultAsync(x => x.PermitID == id);
            return permitToWork;
        }

       
        public async Task<IEnumerable<PermitToWorkForm>>GetAllAsync()
        {
            var AllInfo = _context.permitToWorkForm.ToListAsync();

            return  await AllInfo;
               
              
                          
        }

       
    }
}
