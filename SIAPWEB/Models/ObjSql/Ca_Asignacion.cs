using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAPWEB.Models.ObjSql
{
    public class Ca_Asignacion
    {
        public int Id_Asignacion { set; get; }
        public string Codigo_Asignacion { set; get; }
        public string Descripcion { set; get; }
        public DateTime CretaDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime UpdateDate { set; get; }
        public string UpdateBy { set; get; }

        public Ca_Asignacion()
        {
            Id_Asignacion = 0;
            Codigo_Asignacion = "";
            Descripcion = "";
            CretaDate = DateTime.Now;
            CreateBy = "";
            UpdateDate = DateTime.Now;
            UpdateBy = "";
        }

    }
}
