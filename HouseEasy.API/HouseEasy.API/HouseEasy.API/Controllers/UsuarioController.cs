using AutoMapper;
using HouseEasy.Application.Contracts.Request.Usuarios;
using HouseEasy.Application.Contracts.Responses.Usuarios;
using HouseEasy.Domain.Entities.Usuarios;
using HouseEasy.Domain.Interfaces.Service.Usuarios;
using Microsoft.AspNetCore.Mvc;

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
        [ProducesResponseType(typeof(List<UsuarioResponse>), 200)]
        public IActionResult GetAll()
        {
            return Ok(_mapper.Map<List<UsuarioResponse>>(_service.GetAll()));
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(UsuarioResponse), 200)]
        public IActionResult GetById(int id)
        {
            Usuario? usuario = _service.GetById(id);
            if (usuario == null)
                return NotFound("Registro não encontrado");

            return Ok(_mapper.Map<UsuarioResponse>(_service.GetById(id)));
        }

        // POST api/<UsuarioController>
        [HttpPost]
        [ProducesResponseType(typeof(UsuarioResponse), 200)]
        public async Task<UsuarioResponse> Post([FromBody] UsuarioRequest newUser)
        {
            Usuario? usuario = _mapper.Map<Usuario>(newUser);
            usuario = await _service.Create(usuario);

            return _mapper.Map<UsuarioResponse>(usuario);
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(UsuarioResponse), 200)]
        public IActionResult Put(int id, [FromBody] UsuarioUpdateRequest usuarioRequest)
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
        [ProducesResponseType( 200)]
        public IActionResult Delete(int id)
        {
            var result = _service.Delete(id);
            if (result)
                return Ok("Registro apagado com sucesso");
            return BadRequest("Registro não existe na base");
        }
    }
}
