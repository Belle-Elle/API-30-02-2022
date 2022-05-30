using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SenaiSCSV14.Domains
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nif { get; set; }
        public string Senha { get; set; }
    }
}
