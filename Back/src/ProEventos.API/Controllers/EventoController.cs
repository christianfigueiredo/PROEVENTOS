using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento>  evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Local = "São Paulo",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                Tema = "Angular e .NET",
                QtdPessoas = 250,
                Lote = "1º Lote",
                ImagemURL = "foto.png"
            },
            new Evento() {
                EventoId = 2,
                Local = "Rio de Janeiro",
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                Tema = "React e .NET",
                QtdPessoas = 300,
                Lote = "2º Lote",
                ImagemURL = "foto2.png"
            }
        };
    public EventoController()
    {

    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return evento;

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
