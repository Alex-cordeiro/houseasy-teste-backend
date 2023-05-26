using AutoMapper;
using HouseEasy.Application.Contracts.Request.Enderecos;
using HouseEasy.Domain.Entities.Enderecos;
using HouseEasy.Domain.Interfaces.Service.Enderecos;
using Microsoft.AspNetCore.Mvc;

namespace HouseEasy.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _service;
        private readonly IMapper _mapper;

        public EnderecoController(IEnderecoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<EnderecoController>
        [HttpGet]
        [ProducesResponseType(typeof(List<EnderecoRequest>), 200)]
        public IActionResult GetAll()
        {
            return Ok(_mapper.Map<List<EnderecoRequest>>(_service.GetAll()));
        }

        // GET api/<EnderecoController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(EnderecoRequest), 200)]
        public IActionResult GetById(int id)
        {
            Endereco? endereco = _service.GetById(id);
            if(endereco == null)
                return NotFound("Registro não encontrado");

            return Ok(_mapper.Map<EnderecoRequest>(endereco));
        }

        // POST api/<EnderecoController>
        [HttpPost]
        [ProducesResponseType(typeof(EnderecoRequest), 200)]
        public async Task<EnderecoRequest> Post([FromBody] EnderecoRequest newEndereco)
        {
            Endereco? enderecoInsert = _mapper.Map<Endereco>(newEndereco);
            enderecoInsert = await _service.Create(enderecoInsert);

            return _mapper.Map<EnderecoRequest>(enderecoInsert);
        }

        // PUT api/<EnderecoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EnderecoRequest enderecoRequest)
        {
            Endereco? endereco = _mapper.Map<Endereco>(enderecoRequest);
            endereco.Id = id;

            var result = _service.Update(endereco);

            if (result)
                return Ok("Registro alterado com sucesso");
            return BadRequest("Não foi possível realizar a ação");
        }

        // DELETE api/<EnderecoController>/5
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
