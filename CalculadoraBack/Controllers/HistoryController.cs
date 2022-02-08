using CalculadoraBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculadoraBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public HistoryController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<HistoryController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listHistory = await _context.history.ToListAsync();
                return Ok(listHistory);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        // GET api/<HistoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HistoryController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] History history)
        {
            try
            {
                _context.Add(history);
                await _context.SaveChangesAsync();
                return Ok(history);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        // PUT api/<HistoryController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] History history)
        {
            try
            {
                if (id != history.Id)
                {
                    return NotFound();
                }
                _context.Update(history);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Actualizacion con exito"});

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        // DELETE api/<HistoryController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var history = await _context.history.FindAsync(id);
                if (history == null)
                {
                    return NotFound();
                }
                _context.Remove(history);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Eliminacion con exito" });

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}
