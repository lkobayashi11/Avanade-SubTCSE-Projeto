using System.Threading.Tasks;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Repository
{
    interface IEmployeeRepository: IBaseRepository<Domain.Aggregates.Employee.Entities.Employee,string>
    {
        Task<Employee.Entities.Employee> AddEmployee(Employee.Entities.Employee employee);

    }
}
