using AutoMapper;
using HouseEasy.Application.Contracts.Request.Ocupacoes;
using HouseEasy.Domain.Entities.Ocupacoes;
using HouseEasy.Domain.Interfaces.Service.Ocupacoes;
using Microsoft.AspNetCore.Mvc;

namespace HouseEasy.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OcupacaoController : ControllerBase
    {
        private readonly IOcupacaoService _service;
        private readonly IMapper _mapper;

        public OcupacaoController(IOcupacaoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<OcupacaoController>
        [HttpGet]
        [ProducesResponseType(typeof(List<OcupacaoRequest>), 200)]
        public IActionResult GetAll()
        {
            return Ok(_mapper.Map<List<OcupacaoRequest>>(_service.GetAll()));
        }

        // GET api/<OcupacaoController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(OcupacaoRequest), 200)]
        public IActionResult GetById(int id)
        {
            Ocupacao? ocupacao = _service.GetById(id);
            if (ocupacao == null)
                return NotFound("Registro não encontrado");

            return Ok(_mapper.Map<OcupacaoRequest>(_service.GetById(id)));
        }

        // POST api/<OcupacaoController>
        [HttpPost]
        [ProducesResponseType(typeof(OcupacaoRequest), 200)]
        public async Task<OcupacaoRequest> Post([FromBody] OcupacaoRequest newOcupacao)
        {
            Ocupacao? ocupacaoInsert = _mapper.Map<Ocupacao>(newOcupacao);
            ocupacaoInsert = await _service.Create(ocupacaoInsert);

            return _mapper.Map<OcupacaoRequest>(ocupacaoInsert);
        }

        // PUT api/<OcupacaoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] OcupacaoRequest ocupacaoRequest)
        {
            Ocupacao? Ocupacao = _mapper.Map<Ocupacao>(ocupacaoRequest);
            Ocupacao.Id = id;

            var result = _service.Update(Ocupacao);

            if (result)
                return Ok("Registro alterado com sucesso");
            return BadRequest("Não foi possível realizar a ação");
        }

        // DELETE api/<OcupacaoController>/5
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
