using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ebookstore;
using ebookstore.Models;

namespace ebookstore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerMessagesController : ControllerBase
    {
        private readonly ebookstoreDbContext _context = new ebookstoreDbContext();
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerMessage>>> GetcustomerMessages()
        {
            return await _context.customerMessages.ToListAsync();
        }

        // GET: api/CustomerMessages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerMessage>> GetCustomerMessage(string id)
        {
            var customerMessage = await _context.customerMessages.FindAsync(id);

            if (customerMessage == null)
            {
                return NotFound();
            }

            return customerMessage;
        }

        // PUT: api/CustomerMessages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerMessage(string id, CustomerMessage customerMessage)
        {
            if (id != customerMessage.customerEmail)
            {
                return BadRequest();
            }

            _context.Entry(customerMessage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerMessageExists(id))
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

        // POST: api/CustomerMessages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerMessage>> PostCustomerMessage(CustomerMessage customerMessage)
        {
            _context.customerMessages.Add(customerMessage);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CustomerMessageExists(customerMessage.customerEmail))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCustomerMessage", new { id = customerMessage.customerEmail }, customerMessage);
        }

        // DELETE: api/CustomerMessages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerMessage(string id)
        {
            var customerMessage = await _context.customerMessages.FindAsync(id);
            if (customerMessage == null)
            {
                return NotFound();
            }

            _context.customerMessages.Remove(customerMessage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerMessageExists(string id)
        {
            return _context.customerMessages.Any(e => e.customerEmail == id);
        }
    }
}
