using System;
using System.Collections.Generic;

#nullable disable

namespace App13.Models
{
    public partial class Registration
    {
        public int ProfileId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public string Adress { get; set; }
    }
}
