using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POCWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Edit()
        {
            return View("Index"); //back to Index view
        }



        public ActionResult Atualiza(string descricao)
        {
            try
            {
                string Retorno;
                string Comando;
                 Comando = "wiaacmgr.exe";
                // TODO: Add update logic here
                string path = Server.MapPath("../TesteArquivo/TestFile.txt"); //make sure you have the File folder to store the files
                System.IO.File.WriteAllText(path, Comando); //create and write the text to file

                Retorno = "Alteração realizada com sucesso.";
                return Json(new { success = true, Mensagem = Retorno }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, Mensagem = "Erro ao atualizar" }, JsonRequestBehavior.AllowGet);
            }
        }

        public string Retorna()
        {
            try
            {
                string path = Server.MapPath("../TesteArquivo/TestFile.txt");
                string text = System.IO.File.ReadAllText(path);
                System.IO.File.Delete(path);
                return text;
            }
            catch (Exception ex)
            {
                return "Wait";
            }
        }

    }
}