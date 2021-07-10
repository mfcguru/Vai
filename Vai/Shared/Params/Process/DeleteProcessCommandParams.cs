using System.ComponentModel.DataAnnotations;

namespace Vai.Shared.Params
{
    public class DeleteProcessCommandParams
    {
        [Required]
        public int Id { get; set; }
    }
}
