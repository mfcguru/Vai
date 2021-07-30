using System.ComponentModel.DataAnnotations;

namespace Vai.Shared.Params
{
    public class AddProcessCommandParams
    {
        [Required]
        public string Client { get; set; }
        [Required]
        public string Robot { get; set; }
        [Required]
        public string TaskDescription { get; set; }
        public string StartTime { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Efficiency { get; set; }
        [Required]
        public string Priority { get; set; }
    }
}
