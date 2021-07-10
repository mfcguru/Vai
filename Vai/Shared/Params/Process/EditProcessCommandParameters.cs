
using System.ComponentModel.DataAnnotations;

namespace Vai.Shared.Params
{
    public class EditProcessCommandParameters : AddProcessCommandParams
    {
        [Required]
        public int ProcessId { get; set; }
    }
}
