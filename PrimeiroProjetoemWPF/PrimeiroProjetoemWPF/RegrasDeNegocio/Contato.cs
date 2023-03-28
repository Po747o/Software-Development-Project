using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoemWPF.RegrasDeNegocio
{
    internal class Contato
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set;}
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
