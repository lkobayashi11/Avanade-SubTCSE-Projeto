using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avanade.SubTCSE.Projeto.Application.Dtos.Employee;

namespace Avanade.SubTCSE.Projeto.Application.Interfaces.Employee
{
    public interface  IEmployeeAppService
    {
        Task<EmployeeDto> AddEmployee(EmployeeDto employeeDto);
    }
}
