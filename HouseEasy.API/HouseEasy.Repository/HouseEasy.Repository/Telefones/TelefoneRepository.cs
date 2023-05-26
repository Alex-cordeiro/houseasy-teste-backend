using HouseEasy.Data.Context;
using HouseEasy.Domain.Entities.Telefones;
using HouseEasy.Domain.Interfaces.Repository.Telefones;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HouseEasy.Repository.Telefones
{
    public class TelefoneRepository : ITelefoneRepository
    {
        private readonly HouseEasyContext _context;
        public TelefoneRepository(HouseEasyContext context)
        {
            _context = context;
        }

        public async Task<Telefone> Add(Telefone entity)
        {
            using Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction? transaction = _context.Database.BeginTransaction();
            try
            {
                _ = _context.Telefones.AddAsync(entity);
                await _context.SaveChangesAsync();
                transaction.Commit();
                return entity;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
        }

        public IQueryable<Telefone> Get(Expression<Func<Telefone, bool>> expression = null)
        {
            return expression != null ?
                 _context.Telefones
                         .Where(expression)
                         .AsQueryable().AsNoTracking() :
                 _context.Telefones
                         .AsQueryable().AsNoTracking();
        }

        public void Remove(Telefone entity)
        {
            using Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction? transaction = _context.Database.BeginTransaction();
            try
            {
                _ = _context.Telefones.Remove(entity);
                _context.SaveChangesAsync();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
        }

        public Telefone Update(Telefone entity)
        {
            using Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction? transaction = _context.Database.BeginTransaction();
            try
            {
                _ = _context.Telefones.Update(entity);
                _context.SaveChanges();
                transaction.Commit();
                return entity;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
        }
    }
}
