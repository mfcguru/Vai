using System.ComponentModel.DataAnnotations;

namespace Vai.Shared.Feagtures.DeleteProcess
{
    public class DeleteProcessCommandParams
    {
        [Required]
        public int Id { get; set; }
    }
}
