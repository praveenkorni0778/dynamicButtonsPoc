using DynamicButtonsPOC.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DynamicButtonsPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ButtonsControllerController : ControllerBase
    {
        public readonly DynamicButtonsContext context;
        public ButtonsControllerController(DynamicButtonsContext Context) 
        {
            context = Context;
        }
        // GET: api/<ButtonsControllerController>
        [HttpGet("[action]/{roleId}/{formId}")]
        public async Task<ActionResult<IEnumerable<Button>>> GetButtons(int roleId, int formId)
        {
            
            var formButtons = context.MapFormButton
                .Where(f => f.FormId == formId)
                .Select(f => f.ButtonId).ToList();
            
            if (formButtons.Any())
            {
                var assignedButtons = context.MapButtonRole
                    .Where(b => b.RoleId == roleId && formButtons.Contains(b.ButtonId))
                    .Select(a => a.ButtonId).ToList();

                if (assignedButtons.Any())
                {
                    var buttons = context.Buttons.Where(b => assignedButtons.Contains(b.Id)).ToList();
                    return Ok(buttons);
                }
            }
            return Ok( new List<Button>());
        }

        // GET api/<ButtonsControllerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ButtonsControllerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ButtonsControllerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ButtonsControllerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
