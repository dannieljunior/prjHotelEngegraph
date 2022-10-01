using Hotel.Comum.Interfaces;
using Hotel.Repositorio.EF;
using Hotel.Repositorio.EF.Classes;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Bll.IOC
{
    public class EFModule : NinjectModule
    {
        public override void Load()
        {
            Bind<HotelDbContext>().ToSelf().InSingletonScope();

            Bind<IRepositorioReserva>().To<RepositorioEFReserva>().InTransientScope();
            Bind<IRepositorioCheckOut>().To<RepositorioEFCheckOut>().InTransientScope();
            Bind<IRepositorioOcupacao>().To<RepositorioEFOcupacao>().InTransientScope();
            Bind<IRepositorioHospede>().To<RepositorioEFHospede>().InTransientScope();
            Bind<IRepositorioConfiguracao>().To<RepositorioEFConfiguracao>().InTransientScope();
            Bind<IRepositorioHospedeOcupacao>().To<RepositorioEFHospedeOcupacao>().InTransientScope();
            Bind<IRepositorioTipoPagto>().To<RepositorioEFTipoPagto>().InTransientScope();
            Bind<IRepositorioLancamentos>().To<RepositorioEFLancamentos>().InTransientScope();
            Bind<IRepositorioTipoUh>().To<RepositorioEFTipoUh>().InTransientScope();
            Bind<IRepositorioUh>().To<RepositorioEFUh>().InTransientScope();
            Bind<IRepositorioUsuario>().To<RepositorioEFUsuario>().InTransientScope();
        }
    }
}
