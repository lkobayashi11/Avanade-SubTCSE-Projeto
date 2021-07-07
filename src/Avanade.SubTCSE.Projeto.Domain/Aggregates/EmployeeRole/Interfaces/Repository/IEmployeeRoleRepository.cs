﻿using System.Threading.Tasks;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository
{
    public interface IEmployeeRoleRepository:IBaseRepository<Entities.EmployeeRole,string>
    
    {
        Task<Entities.EmployeeRole> AddEmployeeRole(Entities.EmployeeRole employeeRole);
    }
}
