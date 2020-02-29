using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAPWEB.Models.ObjSql
{
    public class Ca_Servicios
    {
        public int Id_TipoServicios { set; get; }
        public int Id_Compania { set; get; }
        public string Tipo_Servicios { set; get; }
        public string Codigo_Servicios { set; get; }
        public string Descripcion { set; get; }
        public decimal Tarifa { set; get; }
        public string Umedida { set; get; }
        public string Capacidad { set; get; }
        public DateTime CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime UpdateDate { set; get; }
        public string UpdateBy { set; get; }

        public Ca_Servicios()
        {
            Id_TipoServicios = 0;
            Id_Compania = 0;
            Tipo_Servicios = "";
            Codigo_Servicios = "";
            Descripcion = "";
            Tarifa = 0;
            Umedida = "";
            Capacidad = "";
            CreateDate = DateTime.Now;
            CreateBy = "";
            UpdateDate = DateTime.Now;
            UpdateBy = "";
        }
    }
}
