using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace restful.Models
{
    public static class SimulacaoAutor
    {
        public static List<Autor> ObterTodosAutores()
        {
            List<Autor> dados = new List<Autor>();

            dados.Add(new Autor { Id = 1, Cidade = "rj", Estado = "rj", Nacionalidade = "brasileiro", Nome = "Joao", Passaporte = "7777" });
            dados.Add(new Autor { Id = 2, Cidade = "bh", Estado = "mg", Nacionalidade = "brasileiro", Nome = "maria", Passaporte = "9999" });
            dados.Add(new Autor { Id = 3, Cidade = "vitoria", Estado = "es", Nacionalidade = "brasileiro", Nome = "jucimaria", Passaporte = "3333" });
            dados.Add(new Autor { Id = 3, Cidade = "feira de santana", Estado = "ba", Nacionalidade = "brasileiro", Nome = "jucimaria", Passaporte = "8888" });

            return dados;
        }
    }
}