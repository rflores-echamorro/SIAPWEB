using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAPWEB.Models.ObjSql
{
    public class Ca_Fuente
    {
        public int Id_fuente { set; get; }
        public string Codigo_Fuente { set; get; }
        public string Descripcion { set; get; }
        public DateTime CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime UpdateDate { set; get; }
        public string UpdateBy { set; get; }
        public Ca_Fuente()
        {
            Id_fuente = 0;
            Codigo_Fuente = "";
            Descripcion = "";
            CreateDate = DateTime.Now;
            CreateBy = "";
            UpdateDate = DateTime.Now;
            UpdateBy = "";
        }
    }
}
