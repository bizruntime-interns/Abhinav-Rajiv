using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace necore.model
{
    public class login
    {
        [Required]
        public int id{ get; set; }
        [Required]
        public string Password { get; set; }
      
    }
}
