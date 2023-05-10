 namespace mestreruan.api.controllers;
 using mestreruan.api.Entities;

[Microsoft.AspNetCore.Mvc.ApiController]
[Microsoft.AspNetCore.Mvc.Route("api/[controller]")]

public class FuncionarioController : Microsoft.AspNetCore.Mvc.ControllerBase
{
  [Microsoft.AspNetCore.Mvc.HttpGet(Name = "recuperarEletricistasAtivos")]
  public Microsoft.AspNetCore.Mvc.ActionResult<IEnumerable<Funcionario>> Get()
  {
    try
    {
      return mestreruan.api.Models.FuncionarioDAO.recuperarFuncionarios();
    }
    catch (System.InvalidOperationException)
    {
      return NotFound();
    }
  }
  [Microsoft.AspNetCore.Mvc.HttpGet("{re}", Name = "recuperarFuncionario")]
  public Microsoft.AspNetCore.Mvc.ActionResult<Funcionario> Get(int re)
  {
    try
    {
      return mestreruan.api.Models.FuncionarioDAO.recuperarFuncionario(re);
    }
    catch (System.InvalidOperationException)
    {
      return NotFound();
    }
  }
  [Microsoft.AspNetCore.Mvc.HttpPost(Name = "inserirFuncionario")]
  public Microsoft.AspNetCore.Mvc.ActionResult Post(Funcionario funcionario)
  {
    try
    {
      mestreruan.api.Models.FuncionarioDAO.inserirFuncionario(funcionario);
      return NoContent();
    }
    catch (System.InvalidOperationException)
    {
      return BadRequest();
    }
  }
  [Microsoft.AspNetCore.Mvc.HttpPut(Name = "AlterarFuncionario")]
  public Microsoft.AspNetCore.Mvc.ActionResult Put(Funcionario funcionario)
  {
    try
    {
      mestreruan.api.Models.FuncionarioDAO.alterarFuncionario(funcionario);
      return NoContent();
    }
    catch (System.InvalidOperationException)
    {
      return BadRequest();
    }
  }
  [Microsoft.AspNetCore.Mvc.HttpDelete(Name = "ApagarFuncionario")]
  public Microsoft.AspNetCore.Mvc.ActionResult Delete(Funcionario funcionario)
  {
    try
    {
      mestreruan.api.Models.FuncionarioDAO.apagarFuncionario(funcionario);
      return NoContent();
    }
    catch (System.InvalidOperationException)
    {
      return BadRequest();
    }
  }
}
