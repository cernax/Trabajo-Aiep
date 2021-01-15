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
    public class ConsultaDetDocumento
    {
        public List<DetDocumento> ConsutaDetDocumento(DetDocumento detDocumento)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryConsulta = "SELECT " +
                                        "Id_Detalle," +
                                        "Id_Documento," +
                                        "Id_NCorrelativo," +
                                        "Id_Producto," +
                                        "iCantidad," +
                                        "iTotalParcial," +
                                        "from " +
                                        "TBL_Detalle_Documento";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryConsulta, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<DetDocumento> lista = new List<DetDocumento>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DetDocumento agregar = new DetDocumento();

                        agregar.Id_Detalle = int.Parse(dt.Rows[i][0].ToString());
                        agregar.Id_Documento = int.Parse(dt.Rows[i][1].ToString());
                        agregar.Id_NCorrelativo = int.Parse(dt.Rows[i][2].ToString());
                        agregar.Id_Producto = int.Parse(dt.Rows[i][5].ToString());
                        agregar.iCantidad = int.Parse(dt.Rows[i][6].ToString());
                        agregar.iTotalParcial = int.Parse(dt.Rows[i][7].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<DetDocumento>();
                }
            }
            catch (Exception ex)
            {
                return new List<DetDocumento>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public List<DetDocumento> BuscarDetDocumento(DetDocumento detDocumento)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryBuscar = "SELECT  " +
                                        "Id_Detalle," +
                                        "Id_Documento," +
                                        "Id_NCorrelativo," +
                                        "Id_Producto," +
                                        "iCantidad," +
                                        "iTotalParcial," +
                                        "from " +
                                        "TBL_Detalle_Documento where Id_DetDocumento=" + detDocumento.Id_Detalle;

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryBuscar, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<DetDocumento> lista = new List<DetDocumento>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DetDocumento agregar = new DetDocumento();

                        agregar.Id_Detalle = int.Parse(dt.Rows[i][0].ToString());
                        agregar.Id_Documento = int.Parse(dt.Rows[i][1].ToString());
                        agregar.Id_NCorrelativo = int.Parse(dt.Rows[i][2].ToString());
                        agregar.Id_Producto = int.Parse(dt.Rows[i][5].ToString());
                        agregar.iCantidad = int.Parse(dt.Rows[i][6].ToString());
                        agregar.iTotalParcial = int.Parse(dt.Rows[i][7].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<DetDocumento>();
                }
            }
            catch (Exception ex)
            {
                return new List<DetDocumento>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public bool registraDetDocumento(DetDocumento detDocumento)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryElimina = "DELETE TBL_Detalle_Documento where Id_Detalle=" + detDocumento.Id_Detalle;

                conectaBD.abrirConexion();

                SqlCommand cmdet = new SqlCommand(queryElimina, conectaBD.Conexion);

                int auxdet = cmdet.ExecuteNonQuery();

                conectaBD.cerrarConexion();

                if (auxdet == 0)
                {
                    string queryInsert = "INSERT INTO TBL_Detalle_Documento (" +
                                            "[Id_iTem]," +
                                            "[Id_Producto]," +
                                            "[iCantidad]," +
                                            "[iTotalParcial]" +
                                            ")VALUES (" +
                                            //detDocumento.Id_Documento + "," +
                                            detDocumento.Id_NCorrelativo + "," +
                                            detDocumento.Id_Producto + "," +
                                            detDocumento.iCantidad + "," +
                                            detDocumento.iTotalParcial + ");";

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
    }
}
