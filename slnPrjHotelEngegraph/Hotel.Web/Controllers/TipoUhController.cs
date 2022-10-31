using Hotel.Bll.Classes;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel.Web.Controllers
{
    public class TipoUhController : Controller
    {
        private readonly TipoUhBll bll = new TipoUhBll();
        // GET: TipoUh
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ActionName("Get")]
        public JsonResult GetById(string id)
        {
            var obj = bll.GetById(new Guid(id));
            obj.Uhs.Clear();
            var result = Json(obj, JsonRequestBehavior.AllowGet);
            return result;
        }
    }
}