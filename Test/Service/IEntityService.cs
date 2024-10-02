﻿namespace Test.Service
{
    public interface IEntityService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Add(T entity);
        Task Update(int id, T entity);
        Task Delete(int id);
    }
}