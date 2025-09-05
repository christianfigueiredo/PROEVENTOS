using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    private readonly Contexto _context;
    public EventoController(Contexto contexto)
    {
        _context = contexto;
    }   
   

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos.ToList();

    }

    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
        return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);

    }

    [HttpPost]
    public string Post()
    {
        return "Evento Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Evento Put com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Evento Delete com id = {id}";
    }
}
