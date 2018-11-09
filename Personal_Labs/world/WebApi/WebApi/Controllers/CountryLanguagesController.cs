﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryLanguagesController : ControllerBase
    {
        private readonly WorldDbContext _context;

        public CountryLanguagesController(WorldDbContext context)
        {
            _context = context;
        }

        // GET: api/CountryLanguages
        [HttpGet]
        public IEnumerable<CountryLanguage> GetCountryLanguage()
        {
            return _context.CountryLanguage;
        }

        // GET: api/CountryLanguages/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCountryLanguage([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var countryLanguage = await _context.CountryLanguage.FindAsync(id);

            if (countryLanguage == null)
            {
                return NotFound();
            }

            return Ok(countryLanguage);
        }

        // PUT: api/CountryLanguages/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountryLanguage([FromRoute] int id, [FromBody] CountryLanguage countryLanguage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != countryLanguage.CountryCode)
            {
                return BadRequest();
            }

            _context.Entry(countryLanguage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryLanguageExists(id))
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

        // POST: api/CountryLanguages
        [HttpPost]
        public async Task<IActionResult> PostCountryLanguage([FromBody] CountryLanguage countryLanguage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CountryLanguage.Add(countryLanguage);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CountryLanguageExists(countryLanguage.CountryCode))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCountryLanguage", new { id = countryLanguage.CountryCode }, countryLanguage);
        }

        // DELETE: api/CountryLanguages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountryLanguage([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var countryLanguage = await _context.CountryLanguage.FindAsync(id);
            if (countryLanguage == null)
            {
                return NotFound();
            }

            _context.CountryLanguage.Remove(countryLanguage);
            await _context.SaveChangesAsync();

            return Ok(countryLanguage);
        }

        private bool CountryLanguageExists(int id)
        {
            return _context.CountryLanguage.Any(e => e.CountryCode == id);
        }
    }
}