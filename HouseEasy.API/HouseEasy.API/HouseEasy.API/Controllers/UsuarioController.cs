using AutoMapper;
using HouseEasy.Application.Contracts.Usuarios;
using HouseEasy.Domain.Entities.Usuarios;
using HouseEasy.Domain.Interfaces.Service.Usuarios;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HouseEasy.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;
        private readonly IMapper _mapper;

        public UsuarioController(IUsuarioService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        [ProducesResponseType(typeof(List<UsuarioRequest>), 200)]
        public IActionResult GetAll()
        {
            return Ok(_mapper.Map<List<UsuarioRequest>>(_service.GetAll()));
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(UsuarioRequest), 200)]
        public UsuarioRequest GetById(int id)
        {
            return _mapper.Map<UsuarioRequest>(_service.GetById(id));
        }

        // POST api/<UsuarioController>
        [HttpPost]
        [ProducesResponseType(typeof(UsuarioRequest), 200)]
        public async Task<UsuarioRequest> Post([FromBody] UsuarioRequest newUser)
        {
            Usuario? usuario = _mapper.Map<Usuario>(newUser);
            usuario = await _service.Create(usuario);

            return _mapper.Map<UsuarioRequest>(usuario);
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UsuarioRequest usuarioRequest)
        {
            Usuario? usuario = _mapper.Map<Usuario>(usuarioRequest);
            usuario.Id = id;

            var result = _service.Update(usuario);

            if(result)
                return Ok("Registro alterado com sucesso");
            return BadRequest("Não foi possível realizar a ação");
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(UsuarioRequest), 200)]
        public IActionResult Delete(int id)
        {
            var result = _service.Delete(id);
            if (result)
                return Ok("Registro apagado com sucesso");
            return BadRequest("Registro não existe na base");
        }
    }
}
