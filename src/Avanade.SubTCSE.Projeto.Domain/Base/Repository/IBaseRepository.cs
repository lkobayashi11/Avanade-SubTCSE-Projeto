﻿using System.Threading.Tasks;
using Avanade.SubTCSE.Projeto.Domain.Aggregates;

namespace Avanade.SubTCSE.Projeto.Domain.Base.Repository
{
    public interface IBaseRepository<TEntity,Tid>
        where TEntity : BaseEntity<Tid>
    {
        Task<TEntity> Add(TEntity entity);

        Task<TEntity> FindById(Tid id);
    }
}
