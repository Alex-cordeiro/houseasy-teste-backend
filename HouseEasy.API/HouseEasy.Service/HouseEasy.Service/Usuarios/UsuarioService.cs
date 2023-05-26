using HouseEasy.Domain.Entities.Usuarios;
using HouseEasy.Domain.Interfaces.Repository.Usuarios;
using HouseEasy.Domain.Interfaces.Service.Usuarios;

namespace HouseEasy.Service.Usuarios
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _repository = usuarioRepository;
        }

        public Task<Usuario> Create(Usuario entity)
        {
           return _repository.Add(entity);
        }

        public bool Delete(int id)
        {
            var existEntity = _repository.Get(x => x.Id.Equals(id)).FirstOrDefault();
            if (existEntity != null)
                return false;
            _repository.Remove(existEntity);
            return true;
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _repository.Get().ToList();
        }

        public Usuario GetById(int id)
        {
            return _repository.Get(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public bool Update(Usuario entity)
        {
            var existEntity = _repository.Get(x => x.Id.Equals(entity.Id)).FirstOrDefault();
            if (existEntity == null)
                return false;

            _repository.Update(entity);
            return true;
        }
    }
}
