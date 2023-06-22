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
                LastName = data.LastName,
                FirstName = data.FirstName,
                ProjectName = data.Project_Name,
                CompanyAddress = data.CompanyAddress,
                CompanyName = data.CompanyName,
                JSANO = data.JSANO,
                Equipment_Description = data.Equipment_Description,
                Duration_Of_Work = data.Duration_Of_Work,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                StartTime = data.StartTime,
                EndTime = data.EndTime,
                Equipment_To_Be_Used = data.Equipment_To_Be_Used,
                Accent = data.Accent,
                Type_Of_Work = data.Type_OF_Work
                
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
