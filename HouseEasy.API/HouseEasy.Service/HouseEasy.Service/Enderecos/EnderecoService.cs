using HouseEasy.Domain.Entities.Enderecos;
using HouseEasy.Domain.Interfaces.Repository.Enderecos;
using HouseEasy.Domain.Interfaces.Service.Enderecos;

namespace HouseEasy.Service.Enderecos
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _repository;

        public EnderecoService(IEnderecoRepository usuarioRepository)
        {
            _repository = usuarioRepository;
        }

        public Task<Endereco> Create(Endereco entity)
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

        public IEnumerable<Endereco> GetAll()
        {
            return _repository.Get();
        }

        public Endereco GetById(int id)
        {
            return _repository.Get(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public bool Update(Endereco entity)
        {
            var existEntity = _repository.Get(x => x.Id.Equals(entity.Id)).FirstOrDefault();
            if (existEntity == null)
                return false;

            _repository.Update(entity);
            return true;
        }
    }
}
