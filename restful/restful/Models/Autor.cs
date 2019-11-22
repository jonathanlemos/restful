using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace restful.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Passaporte { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Nacionalidade { get; set; }
    }
}