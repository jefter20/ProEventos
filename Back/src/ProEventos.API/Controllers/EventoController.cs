using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                IdEvento = 1,
                Tema = "Angular 11",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                QtdPessoas = 200,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "Foto.png"
            },
            new Evento(){
                IdEvento = 2,
                Tema = ".NET 5",
                Local = "São Paulo",
                Lote = "2º Lote",
                QtdPessoas = 500,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "Foto2.png"
            }
            };
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(Evento => Evento.IdEvento == id);
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"put {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Delete {id}";
        }
    }
}
