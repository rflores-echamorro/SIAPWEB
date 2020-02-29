using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SIAPWEB.Models.ObjSql
{
    public class Ca_Acta
    {
        public string Id_Acta { set; get; }
        public string Empleado { set; get; }
        public DateTime Fecha { set; get; }
        public DateTime Fecha_Creacion { set; get; }
        public string Usuario_Creacion { set; get; }
        public DateTime Fecha_Modifica { set; get; }
        public string Usuario_Modifica { set; get; }
        public string Observacion { set; get; }
        public string Estado { set; get; }
        public int Id_Compania { set; get; }
        public int Id_TipoDocto { set; get; }
        public string Foto { set; get; }
        public string Nombre { set; get; }

        public Ca_Acta()
        {
            Id_Acta = "";
            Empleado = "";
            Fecha = DateTime.Now;
            Fecha_Creacion = DateTime.Now;
            Usuario_Creacion = "";
            Fecha_Modifica = DateTime.Now;
            Usuario_Modifica = "";
            Observacion = "";
            Estado = "";
            Id_Compania = 0;
            Id_TipoDocto = 0;
            Foto = "";
            Nombre = "";
    }
    }
}
