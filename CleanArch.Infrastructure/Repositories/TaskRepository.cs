using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly DataBaseContext _context;
        public TaskRepository(DataBaseContext context)
        {
            _context = context;
        }
        public async Task<Domain.Entities.Task> Add(Domain.Entities.Task task)
        {
            try
            {
                var result = await _context.Tasks.AddAsync(task);
                _context.SaveChanges();

                return result.Entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Domain.Entities.Task task)
        {
            try
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IList<Domain.Entities.Task>> GetAll()
        {
            try
            {
                return await _context.Tasks.AsNoTracking().ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<Domain.Entities.Task> GetById(int id)
        {
            try
            {
                return _context.Tasks.AsNoTracking().FirstAsync(x => x.Id == id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Domain.Entities.Task task)
        {
            try
            {
                _context.Tasks.Attach(task);
                _context.Entry(task).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
