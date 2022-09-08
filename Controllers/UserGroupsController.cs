using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xeynergy_App.Data;
using Xeynergy_App.Models;

namespace Xeynergy_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGroupsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public UserGroupsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/UserGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserGroup>>> GetUserGroups()
        {
          if (_context.UserGroups == null)
          {
              return NotFound();
          }
            return await _context.UserGroups.ToListAsync();
        }

        // GET: api/UserGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserGroup>> GetUserGroup(int id)
        {
          if (_context.UserGroups == null)
          {
              return NotFound();
          }
            var userGroup = await _context.UserGroups.FindAsync(id);

            if (userGroup == null)
            {
                return NotFound();
            }

            return userGroup;
        }

        // PUT: api/UserGroups/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserGroup(int id, UserGroup userGroup)
        {
            if (id != userGroup.ID)
            {
                return BadRequest();
            }

            _context.Entry(userGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserGroupExists(id))
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

        // POST: api/UserGroups
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserGroup>> PostUserGroup(UserGroup userGroup)
        {
          if (_context.UserGroups == null)
          {
              return Problem("Entity set 'ApplicationContext.UserGroups'  is null.");
          }
            _context.UserGroups.Add(userGroup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserGroup", new { id = userGroup.ID }, userGroup);
        }

        // DELETE: api/UserGroups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserGroup(int id)
        {
            if (_context.UserGroups == null)
            {
                return NotFound();
            }
            var userGroup = await _context.UserGroups.FindAsync(id);
            if (userGroup == null)
            {
                return NotFound();
            }

            _context.UserGroups.Remove(userGroup);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserGroupExists(int id)
        {
            return (_context.UserGroups?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
