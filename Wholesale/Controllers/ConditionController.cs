using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wholesale.Models;

namespace Wholesale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConditionController : ControllerBase
    {
        private readonly WholeSale _context;

        public ConditionController(WholeSale context)
        {
            _context = context;
        }

        // GET: api/Condition
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Condition>>> GetCondition()
        {
            return await _context.Condition.ToListAsync();
        }

        // GET: api/Condition/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Condition>> GetCondition(int id)
        {
            var condition = await _context.Condition.FindAsync(id);

            if (condition == null)
            {
                return NotFound();
            }

            return condition;
        }

        // PUT: api/Condition/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCondition(int id, Condition condition)
        {
            if (id != condition.conditionID)
            {
                return BadRequest();
            }

            _context.Entry(condition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConditionExists(id))
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

        // POST: api/Condition
        [HttpPost]
        public async Task<ActionResult<Condition>> PostCondition(Condition condition)
        {
            _context.Condition.Add(condition);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCondition", new { id = condition.conditionID }, condition);
        }

        // DELETE: api/Condition/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Condition>> DeleteCondition(int id)
        {
            var condition = await _context.Condition.FindAsync(id);
            if (condition == null)
            {
                return NotFound();
            }

            _context.Condition.Remove(condition);
            await _context.SaveChangesAsync();

            return condition;
        }

        private bool ConditionExists(int id)
        {
            return _context.Condition.Any(e => e.conditionID == id);
        }
    }
}
