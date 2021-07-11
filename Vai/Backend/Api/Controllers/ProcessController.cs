using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Vai.Backend.Api.Controllers
{   
    using Vai.Shared.Interfaces;
    using Vai.Shared.Models;
    using Vai.Shared.Params;

    [Route("api/[controller]")]
    [ApiController]
    public class ProcessController : ControllerBase
    {
        [HttpGet("getAllProcesses")]
        public async Task<IActionResult> GetAllProcesses(
            [FromServices] ICommandList<GetAllProcessesCommandModel, GetAllProcessesCommandParams> command,
            [FromQuery] int page,
            [FromQuery] int pageSize)
        {
            var result = await command.Execute(new GetAllProcessesCommandParams { Page = page, PageSize = pageSize });

            return Ok(result);
        }

        [HttpGet("getProcess")]
        public async Task<IActionResult> GetProcess(
            [FromServices] ICommand<int, GetProcessCommandModel> command,
            [FromQuery] int id)
        {
            var result = await command.Execute(id);

            return Ok(result);
        }

        [HttpPost("addProcess")]
        public async Task<IActionResult> AddProcess(
            [FromServices]ICommand<AddProcessCommandParams> command, 
            [FromBody]AddProcessCommandParams parameters)
        {
            var result = await command.Execute(parameters);

            return Ok(result);
        }

        [HttpPut("editProcess")]
        public async Task<IActionResult> EditProcess(
            [FromServices]ICommand<EditProcessCommandParameters> command,
            [FromBody]EditProcessCommandParameters parameters)
        {
            var result = await command.Execute(parameters);

            return Ok(result);
        }

        [HttpDelete("deleteProcess")]
        public async Task<IActionResult> DeleteProcess(
            [FromServices]ICommand<DeleteProcessCommandParams> command,
            [FromQuery]int id)
        {
            var result = await command.Execute(new DeleteProcessCommandParams { Id = id });

            return Ok(result);
        }
    }
}
