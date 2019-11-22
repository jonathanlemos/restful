using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using restful.Models;

namespace restful.Controllers
{
    public class AutorController : Controller
    {
        public IEnumerable<Autor> Get()
        {
            return SimulacaoAutor.ObterTodosAutores();
        }
    }
}