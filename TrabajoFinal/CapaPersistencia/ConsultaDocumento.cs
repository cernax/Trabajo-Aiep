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
    public class ConsultaDocumento
    {
        public List<Documento> ConsutaDocumento(Documento documento)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryConsulta = "SELECT " +
                    "[Id_Documento] ," +
                    "td.cNombre ," +
                    "[dFechaDocumento] ," +
                    "[dFechaVigencia] ," +
                    "e.cNombre ," +
                    "c.cNombres ," +
                    "fp.cNombre ," +
                    "[iTotalNeto] ," +
                    "[dTotalPorcentaje] ," +
                    "[iTotalIva] ," +
                    "[iTotalDescuento] ," +
                    "[iTotalGeneral] " +
                    "FROM " +
                    "[TALLER-NET].[dbo].[TBL_Documento] d " +
                    "inner join TBL_TipoDoc td on td.Id_TipoDoc = d.Id_TipoDoc " +
                    "inner join TBL_Empresa e on e.Id_Empresa = d.Id_Empresa " +
                    "inner join TBL_Cliente c on c.Id_Cliente = d.Id_Cliente  " +
                    "inner join TBL_FormaPago fp on fp.Id_FormaPago = d.Id_FormaPago";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryConsulta, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Documento> lista = new List<Documento>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Documento agregar = new Documento();

                        agregar.Id_Documento = int.Parse(dt.Rows[i][0].ToString());
                        agregar.tipdoc = dt.Rows[i][1].ToString();
                        agregar.dFechaDocumento = Convert.ToDateTime(dt.Rows[i][2].ToString());
                        agregar.dFechaVigencia = Convert.ToDateTime(dt.Rows[i][3].ToString());
                        agregar.nomemp = dt.Rows[i][4].ToString();
                        agregar.nomcli = dt.Rows[i][5].ToString();
                        agregar.formpago = dt.Rows[i][6].ToString();
                        agregar.iTotalNeto = int.Parse(dt.Rows[i][7].ToString());
                        agregar.dTotalPorcentaje = int.Parse(dt.Rows[i][8].ToString().Split(',')[0]);
                        agregar.iTotalIva = int.Parse(dt.Rows[i][9].ToString().Split(',')[0]);
                        agregar.iTotalDescuento = int.Parse(dt.Rows[i][10].ToString().Split(',')[0]);
                        agregar.iTotalGeneral = int.Parse(dt.Rows[i][11].ToString().Split(',')[0]);

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Documento>();
                }
            }
            catch (Exception ex)
            {
                return new List<Documento>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public List<Documento> BuscarDocumento(Documento documento)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryBuscar = "SELECT  " +
                                        "Id_Documento," +
                                        "Id_TipoDoc," +
                                        "Id_NCorrelativo," +
                                        "dFechaDocumento," +
                                        "dFechaVigencia," +
                                        "Id_Empresa," +
                                        "Id_Cliente," +
                                        "Id_FormaPago," +
                                        "iTotalNeto," +
                                        "dTotalPorcentaje," +
                                        "iTotalIva," +
                                        "iTotalDescuento," +
                                        "iTotalGeneral," +
                                        "bEmitido," +
                                        "bVigencia " +
                                        "from " +
                                        "TBL_Documento where Id_Documento=" + documento.Id_Documento;

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryBuscar, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Documento> lista = new List<Documento>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Documento agregar = new Documento();

                        agregar.Id_Documento = int.Parse(dt.Rows[i][0].ToString());
                        agregar.Id_TipoDoc = int.Parse(dt.Rows[i][1].ToString());
                        agregar.Id_NCorrelativo = int.Parse(dt.Rows[i][2].ToString());
                        agregar.dFechaDocumento = Convert.ToDateTime(dt.Rows[i][3].ToString());
                        agregar.dFechaVigencia = Convert.ToDateTime(dt.Rows[i][4].ToString());
                        agregar.Id_Empresa = int.Parse(dt.Rows[i][5].ToString());
                        agregar.Id_Cliente = int.Parse(dt.Rows[i][6].ToString());
                        agregar.Id_FormaPago = int.Parse(dt.Rows[i][7].ToString());
                        agregar.iTotalNeto = int.Parse(dt.Rows[i][8].ToString());
                        agregar.dTotalPorcentaje = int.Parse(dt.Rows[i][9].ToString());
                        agregar.iTotalIva = int.Parse(dt.Rows[i][10].ToString());
                        agregar.iTotalDescuento = int.Parse(dt.Rows[i][11].ToString());
                        agregar.iTotalGeneral = int.Parse(dt.Rows[i][12].ToString());
                        agregar.bEmitido = int.Parse(dt.Rows[i][13].ToString());
                        agregar.bVigencia = int.Parse(dt.Rows[i][14].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Documento>();
                }
            }
            catch (Exception ex)
            {
                return new List<Documento>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public bool registraDocumento(Documento documento)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryInsert = "INSERT INTO TBL_Documento VALUES ('" +
                                        documento.Id_Documento + "," +
                                        documento.Id_TipoDoc + "," +
                                        documento.Id_NCorrelativo + ",'" +
                                        documento.dFechaDocumento + "','" +
                                        documento.dFechaVigencia + "'," +
                                        documento.Id_Empresa + "," +
                                        documento.Id_Cliente + "," +
                                        documento.Id_FormaPago + "," +
                                        documento.iTotalNeto + "," +
                                        documento.dTotalPorcentaje + "," +
                                        documento.iTotalIva + "," +
                                        documento.iTotalDescuento + "," +
                                        documento.iTotalGeneral + "," +
                                        documento.bEmitido + "," +
                                        documento.bVigencia + ");";

                conectaBD.abrirConexion();

                SqlCommand cmd = new SqlCommand(queryInsert, conectaBD.Conexion);

                int aux = cmd.ExecuteNonQuery();

                conectaBD.cerrarConexion();

                if (aux > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return false;
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public bool eliminarDocumento(Documento documento)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryElimina = "UPDATE TBL_Documento set bVigencia=" + documento.bVigencia + " where Id_Documento=" + documento.Id_Documento;

                conectaBD.abrirConexion();

                SqlCommand cmd = new SqlCommand(queryElimina, conectaBD.Conexion);

                int aux = cmd.ExecuteNonQuery();

                conectaBD.cerrarConexion();

                if (aux > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return false;
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public bool emitirDocumento(Documento documento)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryEmitir = "UPDATE TBL_Documento set bEmitido=" + documento.bEmitido + " where Id_Documento=" + documento.Id_Documento;

                conectaBD.abrirConexion();

                SqlCommand cmd = new SqlCommand(queryEmitir, conectaBD.Conexion);

                int aux = cmd.ExecuteNonQuery();

                conectaBD.cerrarConexion();

                if (aux > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return false;
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }

        //public CapaEntidades<Documento> VistaDocumento(Documento documento)
        //{
        //    ConexionBD conectaBD = new ConexionBD();

        //    using (SqlConnection cn = new SqlConnection("connection string"))
        //    {
        //        cn.Open();

        //        SqlCommand cmd = new SqlCommand("PA_Consulta_factura", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.AddWithValue("@Id_NCorrelativo", Convert.ToInt32(documento.Id_NCorrelativo));
        //        cmd.Parameters.AddWithValue("@Id_TipoDoc", Convert.ToInt32(documento.Id_TipoDoc));
        //        cmd.Parameters.AddWithValue("@Id_Empresa", Convert.ToInt32(documento.Id_Empresa));
        //        cmd.Parameters.AddWithValue("@Id_Cliente", Convert.ToInt32(documento.Id_Cliente));

        //        SqlDataReader dr = cmd.ExecuteReader();

        //        if (dr.Read())
        //        {
        //            while (reader.Read())
        //            {

        //            }
        //    }
        //}
    }
}
