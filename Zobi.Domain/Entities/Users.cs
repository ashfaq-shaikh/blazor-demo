using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Zobi.Domain.Entities
{
    public class Users
    {
        [Key] public int Id { get; set; }

        [Required] public string Name { get; set; }
    }
}
