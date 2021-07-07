using System;
using System.Threading.Tasks;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Services;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Services
{
    public class EmployeeService : IEmployeeService
    {
        public async Task<Entities.Employee> AddEmployee(Entities.Employee employee)
        {
            throw new NotImplementedException();
        }


    }
}
