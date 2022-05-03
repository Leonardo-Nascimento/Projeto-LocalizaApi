using AutoMapper;
using Localiza.Aplication.Interface;
using Localiza.Domain.Models;
using Localiza.WebAPI.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Localiza.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly IClienteAppService _clienteAppService;
        private readonly IEnderecoAppService _enderecoAppService;
        public readonly IMapper _mapper;


        public ClienteController(
            IClienteAppService clienteAppService,
            IEnderecoAppService enderecoAppService,
            IMapper mapper)
        {
            _clienteAppService = clienteAppService;
            _enderecoAppService = enderecoAppService;
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet("GetAllClientes")]
        public async Task<IEnumerable<Cliente>> GetAllClientes()
        {
            try
            {
                return await _clienteAppService.GetAll();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetClienteById")]
        public async Task<IActionResult> GetClienteById([FromQuery] long id)
        {
            try
            {
                var result = await _clienteAppService.GetById(id);
                if (result != null)
                    return Ok(result);

                return Ok(new { message = $"ClienteId = {id} não encontrato" });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet("GetByCPF")]
        public async Task<Cliente> GetClienteByCPF(string cpf)
        {
            try
            {
                return await _clienteAppService.GetByCPF(cpf);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [HttpPost("InsereCliente")]
        public async Task<IActionResult> InsereCliente([FromBody] ClienteDTO clienteDto)
        {

            var cpfClienteExiste =  await _clienteAppService.GetByCPF(clienteDto.CPF);
            
            if (cpfClienteExiste != null)
                return Ok(new {message = "cpf ja existe na base!", cpf = clienteDto.CPF});

            DateTime dataNascimento = DateTime.Parse(clienteDto.DataNascimento);

            if (dataNascimento.Year > 2004)
                return Ok(new { message = "Você ainda não pode dirigir pois ainda não tem 18 anos!" });

            try
            {
                var cliente = _mapper.Map<Cliente>(clienteDto);
                var endereco = _mapper.Map<Endereco>(clienteDto.Endereco);

                endereco.DataCriacao = DateTime.Now;
                cliente.Endereco = await _enderecoAppService.Add(endereco);

                cliente.DataCriacao = DateTime.Now;
                var result = await _clienteAppService.Add(cliente);

                if (result != null)
                {
                    clienteDto.ClienteId = result.ClienteId;
                    clienteDto.Endereco.EnderecoId = result.EnderecoId;
                    return Json(clienteDto);
                }

                return Json(new { message = "Erro ao tentar adicionar cliente", cliente = clienteDto });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCliente([FromQuery] long id)
        {
            try
            {
                var result = await _clienteAppService.GetById(id);
                if (result == null)
                    return Ok(new { message = $"ClienteId = {id} não encontrato" });

                result.DataExclusao = DateTime.Now;
                result.DataAtualizacao = DateTime.Now;

                var cliente = _clienteAppService.Delete(result);

                return Json(new { message = "Cliente deletado com sucesso!" , cliente = cliente.Result  });
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut("AtualizaEndereco")]
        public async Task<IActionResult> AtualizaEndereco([FromQuery] long ClienteId,[FromBody] EnderecoDTO enderecoDto)
        {

            try
            {
                var cliente = await _clienteAppService.GetById(ClienteId);

                if (cliente == null)
                    return Ok(new { message = $"ClienteId = {ClienteId} não encontrato" });

                cliente.Endereco = await _enderecoAppService.GetById(cliente.EnderecoId);

                cliente.Endereco = _mapper.Map(enderecoDto, cliente.Endereco);
                cliente.Endereco.DataAtualizacao = DateTime.Now;

                var endereco  =  _enderecoAppService.Update(cliente.Endereco);
                
                return Ok(new { message = "O Endereço foi atualizado com sucesso!", Endereco = endereco.Result});

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
