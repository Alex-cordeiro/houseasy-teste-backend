using HouseEasy.Data.Context;
using HouseEasy.Domain.Entities.Usuarios;
using HouseEasy.Domain.Interfaces.Repository.Usuarios;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HouseEasy.Repository.Usuarios
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly HouseEasyContext _context;
        public UsuarioRepository(HouseEasyContext context)
        {
            _context = context;
        }

        public async Task<Usuario> Add(Usuario entity)
        {
            using Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction? transaction = _context.Database.BeginTransaction();
            try
            {
                _ = _context.Usuarios.AddAsync(entity);
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

        public IQueryable<Usuario> Get(Expression<Func<Usuario, bool>> expression = null)
        {
           return expression != null ? 
                _context.Usuarios
                        .Where(expression)
                        .AsQueryable().AsNoTracking() :
                _context.Usuarios
                        .AsQueryable().AsNoTracking();
        }

        public void Remove(Usuario entity)
        {
            using Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction? transaction = _context.Database.BeginTransaction();
            try
            {
                _ = _context.Usuarios.Remove(entity);
                _context.SaveChangesAsync();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
        }

        public Usuario Update(Usuario entity)
        {
            using Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction? transaction = _context.Database.BeginTransaction();
            try
            {
                _ = _context.Usuarios.Update(entity);
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
