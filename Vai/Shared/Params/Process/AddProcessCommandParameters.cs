﻿using System.ComponentModel.DataAnnotations;

namespace Vai.Shared.Params
{
    public class AddProcessCommandParameters
    {
        [Required]
        public string City { get; set; }

        [Required]
        public string Robot { get; set; }

        [Required]
        public string TaskDescription { get; set; }
    }
}
