using Hotel.Bll.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel.Web.Controllers
{
    public class ReservaController : Controller
    {
        private readonly ReservaBll bll = new ReservaBll();

        public ActionResult Index()
        {
            var dtaCheckIn = Convert.ToDateTime(Request.QueryString["dtaCheckIn"] ?? DateTime.Now.ToString());
            var dtaCheckOut = Convert.ToDateTime(Request.QueryString["dtaCheckOut"] ?? DateTime.Now.ToString());
            var tipoUhSelecionado = Request.QueryString["ddlTiposUh"] ?? default(Guid).ToString();

            ViewBag.dtaCheckin = dtaCheckIn;
            ViewBag.dtaCheckOut = dtaCheckOut;

            ViewBag.TiposUh = bll.ObterTiposUh();

            var reservas = bll.ObterReservas(dtaCheckIn, dtaCheckOut, tipoUhSelecionado);
            return View(reservas);
        }
    }
}