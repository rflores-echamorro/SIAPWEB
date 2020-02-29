using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAPWEB.Models.ObjSql
{
    public class Ca_Estados
    {
        public int Id_Estado { set; get; }
        public string Codigo_Estado { set; get; }
        public string Descripcion { set; get; }
        public DateTime CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime UpdateDate { set; get; }
        public string UpdateBy { set; get; }
        public Ca_Estados()
        {
            Id_Estado = 0;
            Codigo_Estado = "";
            Descripcion = "";
            CreateDate = DateTime.Now;
            CreateBy = "";
            UpdateDate = DateTime.Now;
            UpdateBy = "";
        }
    }
}
