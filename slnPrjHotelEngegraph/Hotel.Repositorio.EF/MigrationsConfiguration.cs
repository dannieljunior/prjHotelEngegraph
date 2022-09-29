using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorio.EF
{
    public class MigrationsConfiguration: DbMigrationsConfiguration<HotelDbContext>
    {
        public MigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            
        }
    }
}
