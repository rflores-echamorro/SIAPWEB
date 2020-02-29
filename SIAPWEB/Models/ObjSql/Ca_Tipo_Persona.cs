using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAPWEB.Models.ObjSql
{
    public class Ca_Tipo_Persona
    {
        public int Id_Tipo_Persona { set; get; }
        public string Codigo_Persona { set; get; }
        public string Tipo_Ientificacion { set; get; }
        public string Descripcion { set; get; }
        public DateTime CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime UpdateDate { set; get; }
        public string UpdateBy { set; get; }
        public Ca_Tipo_Persona()
        {
            Id_Tipo_Persona = 0;
            Codigo_Persona = "";
            Tipo_Ientificacion = "";
            Descripcion = "";
            CreateDate = DateTime.Now;
            CreateBy = "";
            UpdateDate = DateTime.Now;
            UpdateBy = "";
        }
    }
}
