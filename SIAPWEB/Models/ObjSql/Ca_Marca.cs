using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAPWEB.Models.ObjSql
{
    public class Ca_Marca
    {
        public int Id_Marca { set; get; }
        public string Codigo_Marca { set; get; }
        public string Descripcion { set; get; }
        public DateTime CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime UpdateDate { set; get; }
        public string UpdateBy { set; get; }
        public Ca_Marca()
        {
            Id_Marca = 0;
            Codigo_Marca = "";
            Descripcion = "";
            CreateDate = DateTime.Now;
            CreateBy = "";
            UpdateDate = DateTime.Now;
            UpdateBy = "";
        }
    }
}
