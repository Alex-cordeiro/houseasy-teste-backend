using HouseEasy.Domain.Entities.Ocupacoes;
using HouseEasy.Domain.Interfaces.Repository.Ocupacoes;
using HouseEasy.Domain.Interfaces.Service.Ocupacoes;

namespace HouseEasy.Service.Ocupacoes
{
    public class OcupacaoService : IOcupacaoService
    {
        private readonly IOcupacaoRepository _repository;

        public OcupacaoService(IOcupacaoRepository repository)
        {
            _repository = repository;
        }

        public Task<Ocupacao> Create(Ocupacao entity)
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

        public IEnumerable<Ocupacao> GetAll()
        {
            return _repository.Get();
        }

        public Ocupacao GetById(int id)
        {
            return _repository.Get(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public bool Update(Ocupacao entity)
        {
            var existEntity = _repository.Get(x => x.Id.Equals(entity.Id)).FirstOrDefault();
            if (existEntity == null)
                return false;

            _repository.Update(entity);
            return true;
        }
    }
}
