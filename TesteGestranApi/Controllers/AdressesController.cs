using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteGestranApi.ContextEntity;
using TesteGestranApi.Interfaces.Service;
using TesteGestranApi.Models;
using TesteGestranApi.Services;

namespace TesteGestranApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressesController : ControllerBase
    {
        private readonly ContextEntityFrame _context;
        private readonly IServiceApiAdress _serviceApiAdress;

        public AdressesController(ContextEntityFrame context, IServiceApiAdress serviceApiAdress)
        {
            _context = context;
            _serviceApiAdress = serviceApiAdress;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdress(int id, Adress adress)
        {
            if (id != adress.Id)
            {
                return BadRequest();
            }

            await _serviceApiAdress.Atualizar(adress);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Adress>> PostAdress(Adress adress)
        {
            _serviceApiAdress.Adicionar(adress);

            return CreatedAtAction("GetAdress", new { id = adress.Id }, adress);
        }

    }
}
