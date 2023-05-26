using HouseEasy.Domain.Entities.Telefones;
using HouseEasy.Domain.Interfaces.Repository.Telefones;
using HouseEasy.Domain.Interfaces.Service.Telefones;

namespace HouseEasy.Service.Telefones
{
    public class TelefoneService : ITelefoneService
    {
        private readonly ITelefoneRepository _repository;
        public Task<Telefone> Create(Telefone entity)
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

        public IEnumerable<Telefone> GetAll()
        {
            return _repository.Get();
        }

        public Telefone GetById(int id)
        {
            return _repository.Get(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public bool Update(Telefone entity)
        {
            var existEntity = _repository.Get(x => x.Id.Equals(entity.Id)).FirstOrDefault();
            if (existEntity == null)
                return false;

            _repository.Update(entity);
            return true;
        }
    }
}
