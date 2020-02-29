using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAPWEB.Models.ObjSql
{
    public class Ca_Acta_Linea
    {
        public string Id_Acta { set; get; }
        public int Linea { set; get; }
        public int Id_Equipo { set; get; }

        public Ca_Acta_Linea()
        {
            Id_Acta = "";
            Linea = 0;
            Id_Equipo = 0;
        }
    }
}
