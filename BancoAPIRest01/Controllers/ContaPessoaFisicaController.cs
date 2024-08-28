using BancoAPIRest01.DTO;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace BancoAPIRest01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaPessoaFisicaController : ControllerBase
    {
        Conta conta;
        public ContaPessoaFisicaController()
        {
            conta = new ContaPessoaFisica("Aposentadoria", ETipoConta.Investimento);
            conta.Agencia = "0001";
            conta.Codigo = 1;
            conta.Digito = "1";
            conta.NumeroConta = " 2345678";
            conta.Pix = "(11)99999-9999";
            conta.ValorConta = 1000000;
        }

        [HttpGet]
        public ActionResult<double> Get()
        {
            try
            {
                return conta.VerSaldo();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{data}")]
        public ActionResult<IEnumerable<Conta>> Get(DateTime data)
        {
            try
            {
                return conta.VerExtrato(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Transferir")]
        public IActionResult Transferir([FromBody] ContaPara contaPara)
        {
            try
            {
                if (contaPara.TipoContaPFPJ != "PF")
                    return BadRequest("Conta precisa ser pessoa f�sica!");

                Conta ctaPara = new ContaPessoaFisica();
                ctaPara.Pix = contaPara.Pix;
                ctaPara.ValorConta = conta.ValorConta;

                conta.Transferir(ctaPara);
                return Ok("Transferido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(string value)
        {
            try
            {
                conta.SetarNome(value);
                return Ok("Nome Setado com sucesso!");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("{codigoConta}")]
        public IActionResult Delete(int codigoConta)
        {
            try
            {
                conta.EncerrarConta(codigoConta);
                return Ok("Conta encerrada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}