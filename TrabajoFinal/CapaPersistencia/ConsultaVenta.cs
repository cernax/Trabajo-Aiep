using CapaEntidades;
using CapaPresentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistencia
{
    public class ConsultaVenta
    {
        public List<Venta> ReporteVenta(Venta documento)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryBuscar = "SELECT  " +
                                    "a.Id_Documento " +
                                    ",a.Id_TipoDoc " +
                                    ",b.cNombre " +
                                    ",a.Id_NCorrelativo " +
                                    ",a.dFechaDocumento " +
                                    ",a.dFechaVigencia " +
                                    ",a.Id_Empresa " +
                                    ",c.cNombre " +
                                    ",a.Id_Cliente " +
                                    ",d.cNombres + ' ' + d.cApellidos " +
                                    ",d.cDireccion " +
                                    ",a.Id_FormaPago " +
                                    ",e.cNombre " +
                                    ",a.iTotalNeto " +
                                    ",a.dTotalPorcentaje " +
                                    ",a.iTotalIva " +
                                    ",a.iTotalDescuento " +
                                    ",a.iTotalGeneral " +
                                    ",a.bEmitido " +
                                    ",a.bVigencia " +
                                    "from " +
                                    "            TBL_Documento a " +
                                    "inner join  TBL_TipoDoc b " +
                                    "on a.Id_TipoDoc = b.Id_TipoDoc " +
                                    "inner join  TBL_Empresa c " +
                                    "on a.Id_Empresa = c.Id_Empresa " +
                                    "inner join  TBL_Cliente d " +
                                    "on a.Id_Cliente = d.Id_Cliente " +
                                    "inner join  TBL_FormaPago e " +
                                    "on a.Id_FormaPago = e.Id_FormaPago " +
                                    "where " +
                                    "dFechaDocumento <='" + documento.dFechaDesde.ToString("yyyy-MM-dd") + " 00:00:00.000" + "'" + " and " +
                                    "dFechaDocumento >='" + documento.dFechaHasta.ToString("yyyy-MM-dd") + " 00:00:00.000" + "'";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryBuscar, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Venta> lista = new List<Venta>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Venta agregar = new Venta();

                        agregar.Id_Documento = int.Parse(dt.Rows[i][0].ToString());
                        agregar.Id_TipoDoc = int.Parse(dt.Rows[i][1].ToString());
                        agregar.cNombreDoc = dt.Rows[i][2].ToString();
                        agregar.Id_NCorrelativo = int.Parse(dt.Rows[i][3].ToString());
                        agregar.dFechaDocumento = dt.Rows[i][4].ToString().ToString();
                        agregar.dFechaVigencia = dt.Rows[i][5].ToString();
                        agregar.Id_Empresa = int.Parse(dt.Rows[i][6].ToString());
                        agregar.cNombreEmpresa = dt.Rows[i][7].ToString();
                        agregar.Id_Cliente = int.Parse(dt.Rows[i][8].ToString());
                        agregar.cNombreCliente = dt.Rows[i][9].ToString();
                        agregar.cDireccion = dt.Rows[i][10].ToString();
                        agregar.Id_FormaPago = int.Parse(dt.Rows[i][11].ToString());
                        agregar.cNombreFP = dt.Rows[i][12].ToString();
                        agregar.iTotalNeto = int.Parse(dt.Rows[i][13].ToString().Split(',')[0]);
                        agregar.dTotalPorcentaje = int.Parse(dt.Rows[i][14].ToString().Split(',')[0]);
                        agregar.iTotalIva = int.Parse(dt.Rows[i][15].ToString().Split(',')[0]);
                        agregar.iTotalDescuento = int.Parse(dt.Rows[i][16].ToString().Split(',')[0]);
                        agregar.iTotalGeneral = int.Parse(dt.Rows[i][17].ToString().Split(',')[0]);
                        agregar.bEmitido = (dt.Rows[i][18].ToString() == "1" ? "SI" : "NO");
                        agregar.bVigencia = (dt.Rows[i][19].ToString() == "1" ? "SI" : "NO");

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Venta>();
                }
            }
            catch (Exception ex)
            {
                return new List<Venta>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
    }
}
