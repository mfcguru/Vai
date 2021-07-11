using System.ComponentModel.DataAnnotations;

namespace Vai.Shared.Feagtures.EditProcess
{
    public class EditProcessCommandParameters
    {
        [Required]
        public int ProcessId { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Robot { get; set; }

        [Required]
        public string TaskDescription { get; set; }
    }
}
