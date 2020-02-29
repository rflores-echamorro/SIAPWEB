using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAPWEB.Models.ObjSql
{
    public class Ca_Compania
    {
        public int Id_Compania { set; get; }
        public string Codigo_Empresa { set; get; }
        public string Nombre_Empresa { set; get; }
        public DateTime CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime UpdateDate { set; get; }
        public string UpdateBy { set; get; }
        public Ca_Compania()
        {
            Id_Compania = 0;
            Codigo_Empresa = "";
            Nombre_Empresa = "";
            CreateDate = DateTime.Now;
            CreateBy = "";
            UpdateDate = DateTime.Now;
            UpdateBy = "";
        }
    }
}
