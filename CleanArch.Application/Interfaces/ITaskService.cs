using CleanArch.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    public interface ITaskService
    {
        Task<Response> GetById(int id);
        Task<Response> GetAll();
        Task<Response> Add(Domain.Entities.Task task);
        Response Update(Domain.Entities.Task task);
        Task<Response> Delete(int id);

    }
}
