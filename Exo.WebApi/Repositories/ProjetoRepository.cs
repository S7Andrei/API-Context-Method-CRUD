using Exo.WebApi.Contexts;
using Exo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Exo.WebApi. Repositories
{
2 references
public class ProjetoRepository
{
11 references
private readonly ExoContext _context;
O references
public ProjetoRepository (Exo Context context)
{ I
_context = context;
}
1 reference
public List<Projeto> Listar()
{
return _context. Projetos. ToList();
// Código novo que completa o CRUD.
0 references
public void Cadastrar (Projeto projeto)
{
_context. Projetos.Add(projeto);
_context. SaveChanges();
}
public Projeto BuscarporId(int id)
{
    _projetoRepository. Cadastrar (projeto);
return StatusCode (201);
}
[HttpGet("{id}")]
public IActionResult BuscarPorId(int id)
{
Projeto projeto = _projetoRepository. BuscarporId(id);
if (projeto == null)
{
return NotFound ();
}
return Ok(projeto);
}
[HttpPut("{id}")]
public IActionResult Atualizar(int id, Projeto projeto)
{
_projetoRepository.Atualizar(id, projeto);
return StatusCode (204);
}
[HttpDelete("{id}")]
0 references
public IAction Result Deletar(int id)
{
try
{
_projetoRepository. Deletar (id);
return StatusCode (204);
}
catch (Exception e)
{
return BadRequest();
}
}
