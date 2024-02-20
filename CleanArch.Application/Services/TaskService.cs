using CleanArch.Application.Interfaces;
using CleanArch.Application.Responses;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _repository;
        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }
        public async Task<Response> GetAll()
        {
            try
            {
                var tasks = await _repository.GetAll();

                return new Response(tasks);
            }
            catch (Exception ex)
            {
                return new Response().AddError(ex.Message);
            }
        }

        public async Task<Response> GetById(int id)
        {
            try
            {
                var task = await _repository.GetById(id);
                if (task == null)
                {
                    return new Response().AddError("Task not found");
                }
                return new Response(task);
            }
            catch (Exception ex)
            {
                return new Response().AddError(ex.Message);
            }
        }
        public async Task<Response> Delete(int id)
        {
            try
            {
                var task = await _repository.GetById(id);
                if (task == null)
                {
                    return new Response().AddError("Task not found");
                }
                _repository.Delete(task);

                return new Response("Task deleted");
            }
            catch (Exception ex)
            {
                return new Response().AddError(ex.Message);
            }
        }

        public async Task<Response> Add(Domain.Entities.Task task)
        {
            try
            {
                var result = await _repository.Add(task);

                return new Response(result);
            }
            catch (Exception ex)
            {
                return new Response().AddError(ex.Message);
            }
        }

        public Response Update(Domain.Entities.Task task)
        {
            try
            {
                _repository.Update(task);
                return new Response(task);
            }
            catch (Exception ex)
            {
                return new Response().AddError(ex.Message);
            }
        }
    }
}
