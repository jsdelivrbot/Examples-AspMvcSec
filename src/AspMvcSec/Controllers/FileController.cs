using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMvcSec.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index(string path)
        {
            return Content(System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory+"\\"+path));
        }
    }
}