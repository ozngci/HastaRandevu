﻿using HastaRandevu.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevu.Data.Repository.Abstract
{
    public interface IRepositoryBase<T> where T : BaseEntity
    {
        Task<int> InsertAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);
        Task<T?> GetByIdAsync(int id);
        Task<T?> GetBy(Expression<Func<T, bool>> filter);
        Task<ICollection<T>> GetAllAsync();
        Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);
        Task<IQueryable<T>> GetAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] include);
    }
}
