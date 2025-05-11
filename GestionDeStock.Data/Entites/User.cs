using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Entites
{
    public class User
    {
        public int UserId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public required string Username { get; set; }
        
        [Required]
        public required string Password { get; set; }
        
        public bool IsAdmin { get; set; }
    }
}
