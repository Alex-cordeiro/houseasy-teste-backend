using HouseEasy.Data.Context;
using HouseEasy.Domain.Entities.Ocupacoes;
using HouseEasy.Domain.Interfaces.Repository.Ocupacoes;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HouseEasy.Repository.Ocupacoes
{
    public class OcupacaoRepository : IOcupacaoRepository
    {
        private readonly HouseEasyContext _context;
        public OcupacaoRepository(HouseEasyContext context)
        {
            _context = context;
        }

        public async Task<Ocupacao> Add(Ocupacao entity)
        {
            using Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction? transaction = _context.Database.BeginTransaction();
            try
            {
                _ = _context.Ocupacoes.AddAsync(entity);
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

        public IQueryable<Ocupacao> Get(Expression<Func<Ocupacao, bool>> expression = null)
        {
            return expression != null ?
                 _context.Ocupacoes
                         .Where(expression)
                         .AsQueryable().AsNoTracking() :
                 _context.Ocupacoes
                         .AsQueryable().AsNoTracking();
        }

        public void Remove(Ocupacao entity)
        {
            using Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction? transaction = _context.Database.BeginTransaction();
            try
            {
                _ = _context.Ocupacoes.Remove(entity);
                _context.SaveChangesAsync();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
        }

        public Ocupacao Update(Ocupacao entity)
        {
            using Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction? transaction = _context.Database.BeginTransaction();
            try
            {
                _ = _context.Ocupacoes.Update(entity);
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
