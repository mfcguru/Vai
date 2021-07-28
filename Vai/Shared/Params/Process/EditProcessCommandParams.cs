
using System.ComponentModel.DataAnnotations;

namespace Vai.Shared.Params
{
    public class EditProcessCommandParams : AddProcessCommandParams
    {
        [Required]
        public int ProcessId { get; set; }
    }
}
