﻿using System.Linq.Expressions;

namespace WheaterApp.Server.Data.IRepositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);
        void Add(T entity);

        void Delete(T entity);

        bool Any(Expression<Func<T, bool>> filter = null);

    }
}