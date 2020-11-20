using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Reportes
    {
		public int Id_Documento { get; set; }		
		public int Id_TipoDoc { get; set; }
		public string cNombreDoc { get; set; }
		public int Id_NCorrelativo { get; set; }
		public string dFechaDocumento { get; set; }
		public string dFechaVigencia { get; set; }
		public int Id_Empresa { get; set; }
		public string cNombreEmpresa { get; set; }
		public int Id_Cliente { get; set; }
		public string cNombreCliente { get; set; }
		public string cDireccion { get; set; }
		public int Id_FormaPago { get; set; }
		public string cNombreFP { get; set; }
		public decimal iTotalNeto { get; set; }
		public decimal dTotalPorcentaje { get; set; }
		public decimal iTotalIva { get; set; }
		public decimal iTotalDescuento { get; set; }
		public decimal iTotalGeneral { get; set; }
		public string bEmitido { get; set; }
		public string bVigencia { get; set; }
		public DateTime dFechaDesde { get; set; }
		public DateTime dFechaHasta { get; set; }
		public int iMes { get; set; }
		public int Ano { get; set; }

		public Reportes()
		{
			Id_Documento = 0;
			Id_TipoDoc = 0;
			cNombreDoc = string.Empty;
			Id_NCorrelativo = 0;
			dFechaDocumento = string.Empty;
			dFechaVigencia = string.Empty;
			Id_Empresa = 0;
			cNombreEmpresa = string.Empty;
			Id_Cliente = 0;
			cNombreCliente = string.Empty;
			cDireccion = string.Empty;
			Id_FormaPago = 0;
			cNombreFP = string.Empty;
			iTotalNeto = 0;
			dTotalPorcentaje = 0;
			iTotalIva = 0;
			iTotalDescuento = 0;
			iTotalGeneral = 0;
			bEmitido = string.Empty;
			bVigencia = string.Empty;
			dFechaDesde = DateTime.Now;
			dFechaHasta = DateTime.Now;
			iMes = 0;
			Ano = 0;
		}		

	}
}
