namespace PermitToWorkSystem.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class
    {
        //Method to add data to the database, we will return nothing.
        Task AddAsync(T entity);
    }
}
