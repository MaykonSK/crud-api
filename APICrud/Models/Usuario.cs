using System;
using System.Collections.Generic;

#nullable disable

namespace APICrud.Models
{
    public partial class Usuario
    {
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Cep { get; set; }
        public string Logradouro { get; set; }
        public int NumeroCasa { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
    }
}
