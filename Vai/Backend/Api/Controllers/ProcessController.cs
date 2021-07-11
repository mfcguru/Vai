using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Vai.Backend.Api.Controllers
{
    using Vai.Shared.Feagtures.AddProcess;
    using Vai.Shared.Feagtures.DeleteProcess;
    using Vai.Shared.Feagtures.EditProcess;
    using Vai.Shared.Feagtures.GetAllProcesses;
    using Vai.Shared.Feagtures.GetProcess;

    [Route("api/[controller]")]
    [ApiController]
    public class ProcessController : ControllerBase
    {
        [HttpGet("getAllProcesses")]
        public async Task<IActionResult> GetAllProcesses([FromServices]IGetAllProcessesCommand command, [FromQuery]int page, [FromQuery]int pageSize)
        {
            var result = await command.Execute(new GetAllProcessesCommandParams { Page = page, PageSize = pageSize });

            return Ok(result);
        }

        [HttpGet("getProcess")]
        public async Task<IActionResult> GetProcess([FromServices]IGetProcessCommand command, [FromQuery] int id)
        {
            var result = await command.Execute(id);

            return Ok(result);
        }

        [HttpPost("addProcess")]
        public async Task<IActionResult> AddProcess([FromServices]IAddProcessCommand command, [FromBody]AddProcessCommandParams parameters)
        {
            var result = await command.Execute(parameters);

            return Ok(result);
        }

        [HttpPut("editProcess")]
        public async Task<IActionResult> EditProcess([FromServices]IEditProcessCommand command, [FromBody]EditProcessCommandParameters parameters)
        {
            var result = await command.Execute(parameters);

            return Ok(result);
        }

        [HttpDelete("deleteProcess")]
        public async Task<IActionResult> DeleteProcess([FromServices]IDeleteProcessCommand command, [FromQuery]int id)
        {
            var result = await command.Execute(new DeleteProcessCommandParams { Id = id });

            return Ok(result);
        }
    }
}
