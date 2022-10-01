using Hotel.Bll.Classes;
using Hotel.Comum.Interfaces;
using Hotel.Repositorio.ADO.Classes;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Bll.IOC
{
    public class ADOModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepositorioReserva>().To<RepositorioADOReserva>().InTransientScope();
            Bind<IRepositorioCheckOut>().To<RepositorioADOCheckOut>().InTransientScope();
            Bind<IRepositorioOcupacao>().To<RepositorioADOOcupacao>().InTransientScope();
            Bind<IRepositorioHospede>().To<RepositorioADOHospede>().InTransientScope();
            Bind<IRepositorioConfiguracao>().To<RepositorioADOConfiguracao>().InTransientScope();
            Bind<IRepositorioHospedeOcupacao>().To<RepositorioADOHospedeOcupacao>().InTransientScope();
            Bind<IRepositorioTipoPagto>().To<RepositorioADOTipoPagto>().InTransientScope();
            Bind<IRepositorioLancamentos>().To<RepositorioADOLancamentos>().InTransientScope();
            Bind<IRepositorioTipoUh>().To<RepositorioADOTipoUh>().InTransientScope();
            Bind<IRepositorioUh>().To<RepositorioADOUh>().InTransientScope();
            Bind<IRepositorioUsuario>().To<RepositorioADOUsuario>().InTransientScope();
        }
    }
}
