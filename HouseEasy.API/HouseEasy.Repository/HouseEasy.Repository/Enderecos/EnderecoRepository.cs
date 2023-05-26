using HouseEasy.Data.Context;
using HouseEasy.Domain.Entities.Enderecos;
using HouseEasy.Domain.Interfaces.Repository.Enderecos;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HouseEasy.Repository.Enderecos
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly HouseEasyContext _context;
        public EnderecoRepository(HouseEasyContext context)
        {
            _context = context;
        }

        public async Task<Endereco> Add(Endereco entity)
        {
            using Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction? transaction = _context.Database.BeginTransaction();
            try
            {
                _ = _context.Enderecos.AddAsync(entity);
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

        public IQueryable<Endereco> Get(Expression<Func<Endereco, bool>> expression = null)
        {
            return expression != null ?
                 _context.Enderecos
                         .Where(expression)
                         .AsQueryable().AsNoTracking() :
                 _context.Enderecos
                         .AsQueryable().AsNoTracking();
        }

        public void Remove(Endereco entity)
        {
            using Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction? transaction = _context.Database.BeginTransaction();
            try
            {
                _ = _context.Enderecos.Remove(entity);
                _context.SaveChangesAsync();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
        }

        public Endereco Update(Endereco entity)
        {
            using Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction? transaction = _context.Database.BeginTransaction();
            try
            {
                _ = _context.Enderecos.Update(entity);
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
