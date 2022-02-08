using System;
using System.Collections.Generic;

#nullable disable

namespace APICrud.Models
{
    public partial class Post
    {
        public int IdPost { get; set; }
        public string TituloPost { get; set; }
        public string TextoPost { get; set; }
        public int CpfUsuario { get; set; }
    }
}
