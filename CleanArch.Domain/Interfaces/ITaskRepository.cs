namespace CleanArch.Domain.Interfaces
{
    public interface ITaskRepository
    {
        public Task<Entities.Task> GetById(int id);
        public Task<IList<Entities.Task>> GetAll();
        public Task<Entities.Task> Add(Entities.Task task);
        public void Update(Entities.Task task);
        public void Delete(Entities.Task task);
    }
}
