﻿using BarberShop_Api.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BarberShop_Api.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly ConnectionContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ConnectionContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id) ?? throw new Exception("ID entered is null or no such");


            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public void Post(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public List<T> Get()
        {
            return _dbSet.ToList();
        }
    }
}
