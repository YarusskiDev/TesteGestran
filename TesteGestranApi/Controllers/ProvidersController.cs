using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteGestranApi.ContextEntity;
using TesteGestranApi.Dto;
using TesteGestranApi.Interfaces.Service;
using TesteGestranApi.Models;

namespace TesteGestranApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvidersController : ControllerBase
    {
        private readonly ContextEntityFrame _context;
        private readonly IServiceApiProvider _serviceProvider;
        private readonly IServiceApiAdress _serviceAdress;

        public ProvidersController(ContextEntityFrame context, IServiceApiProvider serviceProvider, IServiceApiAdress serviceAdress)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            _serviceAdress = serviceAdress;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Provider>>> GetProviders(string? name, string? city, string? companyCode)
        {
            return await (from p in _context.Providers.Include(p => p.Adresses)
                          join e in _context.Adresses on p.Id equals e.Id_Provider
                          where
                          (string.IsNullOrEmpty(name) || p.Name.ToLower() == name.ToLower()) &&
                          (string.IsNullOrEmpty(city) || e.City.ToLower() == city.ToLower()) &&
                          (string.IsNullOrEmpty(companyCode) || p.Cnpj.ToLower() == companyCode.ToLower())
                          select p)
                          .ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Provider>> GetProvider(int id)
        {
            var provider = await _context.Providers.FindAsync(id);

            if (provider == null)
            {
                return NotFound();
            }

            return provider;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProvider(int id, Provider provider)
        {
            if (id != provider.Id)
            {
                return BadRequest();
            }

            _context.Entry(provider).State = EntityState.Modified;

            try
            {
                await _serviceProvider.Atualizar(provider);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProviderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Provider>> PostProvider(ProviderDto provider)
        {
            Provider providerInsert = new Provider()
            {
                Name = provider.Name,
                Cnpj = provider.Cnpj,
                Email = provider.Email,
                Telephone = provider.Telephone
            };

            await _serviceProvider.Adicionar(providerInsert);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProvider(int id)
        {
            await _serviceProvider.Remover(id);
            return NoContent();
        }

        private bool ProviderExists(int id)
        {
            return _context.Providers.Any(e => e.Id == id);
        }
    }
}
