using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAPWEB.Models.ObjSql
{
    public class Ca_Equipos
    {
        public int Id_Equipos { set; get; }
        public int Id_Compania { set; get; }
        public int Id_Marca { set; get; }
        public int Id_Ubicacion { set; get; }
        public int Id_TipoEquipo { set; get; }
        public string Descripcion { set; get; }
        public string Serie { set; get; }
        public string Modelo { set; get; }
        public int Id_Estado { set; get; }
        public int Id_Asignacion { set; get; }
        public int Id_Fuente { set; get; }
        public decimal Costo_Unitario { set; get; }
        public DateTime CreateDate { set; get; }
        public string CreateBy { set; get; }
        public DateTime UpdateDate { set; get; }
        public string UpdateBy { set; get; }
        public string Color { set; get; }
        public string NumeroContrato { set; get; }
        public string Moneda { set; get; }
        public string Activo_Fijo { set; get; }
        public Ca_Equipos()
        {
            Id_Equipos = 0;
            Id_Compania = 0;
            Id_Marca = 0;
            Id_Ubicacion = 0;
            Id_TipoEquipo = 0;
            Descripcion = "";
            Serie = "";
            Modelo = "";
            Id_Estado = 0;
            Id_Asignacion = 0;
            Id_Fuente = 0;
            Costo_Unitario = 0;
            CreateDate = DateTime.Now;
            CreateBy = "";
            UpdateDate = DateTime.Now;
            UpdateBy = "";
            Color = "";
            NumeroContrato = "";
            Moneda = "";
            Activo_Fijo = "";
    }
    }
}
