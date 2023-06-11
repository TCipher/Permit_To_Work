namespace PermitToWorkSystem.Data.Base
{

    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();

        }



    }
}
