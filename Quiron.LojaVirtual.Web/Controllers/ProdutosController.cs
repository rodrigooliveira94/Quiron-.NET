using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        /*_repositorio => é do tipo ProdutosRepositorio encontrado (Quiron...Dominio)
         * ProdutosRepositorio => herda da entidade EfDbContext (Quiron...Dominio)
         * EfDbContext => Possui DbSet das Classes
        */

        private ProdutosRepositorio _repositorio;
        

        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos.Take(10); //Lista os primeiros 10
            return View(produtos);
        }
	}
}