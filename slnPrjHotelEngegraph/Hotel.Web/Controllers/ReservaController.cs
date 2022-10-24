using Hotel.Bll.Classes;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
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

            ViewBag.dtaCheckin = dtaCheckIn.ToString("dd/MM/yyyy");
            ViewBag.dtaCheckOut = dtaCheckOut.ToString("dd/MM/yyyy");

            ViewBag.TiposUh = ObterTiposUh();

            var reservas = bll.ObterReservas(dtaCheckIn, dtaCheckOut, tipoUhSelecionado);
            return View(reservas);
        }

        public ActionResult Edit(string id)
        {
            Reserva obj = new Reserva();

            if (!string.IsNullOrWhiteSpace(id))
                obj = bll.GetById(new Guid(id));

            ViewBag.TiposUh = ObterTiposUh(false);

            return View(obj);
        }

        [HttpPost]
        public ActionResult Edit(Reserva obj)
        {
            var operacao = (obj.Id == default(Guid) ? EnOperacao.Insert : EnOperacao.Update);
            //adicionar codigo de validação
            var result = bll.Persistir(obj, operacao);
            return RedirectToAction("Edit", new { @id = result.Id.ToString() });
        }


        private List<SelectListItem> ObterTiposUh(bool isConsulta = true)
        {
            var lista = bll.ObterTiposUh(isConsulta);
            var selectList = new List<SelectListItem>();
            lista.ForEach(x =>
            {
                selectList.Add(new SelectListItem { Text = x.Descricao, Value = x.Id.ToString() });
            });

            return selectList;
        }
    }
}