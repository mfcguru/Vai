
using System.ComponentModel.DataAnnotations;

namespace Vai.Shared.Params
{
    public class EditProcessCommandParameters : AddProcessCommandParameters
    {
        [Required]
        public int ProcessId { get; set; }
    }
}
