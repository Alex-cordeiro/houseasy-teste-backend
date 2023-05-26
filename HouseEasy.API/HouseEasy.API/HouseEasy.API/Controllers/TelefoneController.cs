using AutoMapper;
using HouseEasy.Application.Contracts.Telefones;
using HouseEasy.Domain.Entities.Telefones;
using HouseEasy.Domain.Interfaces.Service.Telefones;
using Microsoft.AspNetCore.Mvc;

namespace HouseEasy.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TelefoneController : ControllerBase
    {
        private readonly ITelefoneService _service;
        private readonly IMapper _mapper;

        public TelefoneController(ITelefoneService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<TelefoneController>
        [HttpGet]
        [ProducesResponseType(typeof(List<TelefoneRequest>), 200)]
        public IActionResult GetAll()
        {
            return Ok(_mapper.Map<List<TelefoneRequest>>(_service.GetAll()));
        }

        // GET api/<TelefoneController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TelefoneRequest), 200)]
        public TelefoneRequest GetById(int id)
        {
            return _mapper.Map<TelefoneRequest>(_service.GetById(id));
        }

        // POST api/<TelefoneController>
        [HttpPost]
        [ProducesResponseType(typeof(TelefoneRequest), 200)]
        public async Task<TelefoneRequest> Post([FromBody] TelefoneRequest newTelefone)
        {
            Telefone? telefoneInsert = _mapper.Map<Telefone>(newTelefone);
            telefoneInsert = await _service.Create(telefoneInsert);

            return _mapper.Map<TelefoneRequest>(telefoneInsert);
        }

        // PUT api/<TelefoneController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TelefoneRequest telefoneRequest)
        {
            Telefone? telefone = _mapper.Map<Telefone>(telefoneRequest);
            telefone.Id = id;

            var result = _service.Update(telefone);

            if (result)
                return Ok("Registro alterado com sucesso");
            return BadRequest("Não foi possível realizar a ação");
        }

        // DELETE api/<TelefoneController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(200)]
        public IActionResult Delete(int id)
        {
            var result = _service.Delete(id);
            if (result)
                return Ok("Registro apagado com sucesso");
            return BadRequest("Registro não existe na base");
        }
    }
}
