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
    public class ConsultaEmpresa
    {
        public List<Empresa> ConsutaEmpresa(Empresa empresa)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryConsulta = "SELECT " +
                                        "Id_Empresa," +
                                        "iRut," +
                                        "cDv," +
                                        "cNombre," +
                                        "cDireccion," +
                                        "cTelefono," +
                                        "vCorreo," +
                                        "dFechaCreacion " +
                                        "from " +
                                        "TBL_Empresa";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryConsulta, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Empresa> lista = new List<Empresa>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Empresa agregar = new Empresa();

                        agregar.Id_Empresa = int.Parse(dt.Rows[i][0].ToString());
                        agregar.iRut = int.Parse(dt.Rows[i][1].ToString());
                        agregar.cDv = dt.Rows[i][2].ToString();
                        agregar.cNombre = dt.Rows[i][3].ToString();
                        agregar.cDireccion = dt.Rows[i][4].ToString();
                        agregar.cTelefono = dt.Rows[i][5].ToString();
                        agregar.vCorreo = dt.Rows[i][6].ToString();
                        agregar.dFechaCreacion = Convert.ToDateTime(dt.Rows[i][7].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Empresa>();
                }
            }
            catch (Exception ex)
            {
                return new List<Empresa>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public List<Empresa> BuscarEmpresa(Empresa empresa)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryBuscar = "SELECT " +
                                        "Id_Empresa," +
                                        "iRut," +
                                        "cDv," +
                                        "cNombre," +
                                        "cDireccion," +
                                        "cTelefono," +
                                        "vCorreo," +
                                        "dFechaCreacion " +
                                        "from " +
                                        "TBL_Empresa " +
                                        "where " +
                                        "Id_Empresa=" + empresa.Id_Empresa;

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryBuscar, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Empresa> lista = new List<Empresa>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Empresa agregar = new Empresa();

                        agregar.Id_Empresa = int.Parse(dt.Rows[i][0].ToString());
                        agregar.iRut = int.Parse(dt.Rows[i][1].ToString());
                        agregar.cDv = dt.Rows[i][2].ToString();
                        agregar.cNombre = dt.Rows[i][3].ToString();
                        agregar.cDireccion = dt.Rows[i][4].ToString();
                        agregar.cTelefono = dt.Rows[i][5].ToString();
                        agregar.vCorreo = dt.Rows[i][6].ToString();
                        agregar.dFechaCreacion = Convert.ToDateTime(dt.Rows[i][7].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Empresa>();
                }
            }
            catch (Exception ex)
            {
                return new List<Empresa>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public bool registraEmpresa(Empresa empresa)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                var fec = empresa.dFechaCreacion.ToString("yyyy-MM-dd 00:00:00.000");

                string queryInsert = "INSERT INTO TBL_Empresa " +
                                            "(" +
                                            "iRut," +
                                            "cDv," +
                                            "cNombre," +
                                            "cDireccion," +
                                            "cTelefono," +
                                            "vCorreo," +
                                            "bVigencia," +
                                            "dFechaCreacion " +
                                            ") " +
                                            "VALUES " +
                                            "(" +
                                            empresa.iRut + ",'" +
                                            empresa.cDv + "','" +
                                            empresa.cNombre + "','" +
                                            empresa.cDireccion + "'," +
                                            empresa.cTelefono + ",'" +
                                            empresa.vCorreo + "'," +
                                            empresa.bVigencia + ",'" +
                                            fec +
                                            "');";

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
        public bool modificarEmpresa(Empresa empresa)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryModifica = "UPDATE " +
                                        "TBL_Empresa set " +
                                        "cNombre='" + empresa.cNombre + "', " +
                                        "cDireccion='" + empresa.cDireccion + "', " +
                                        "cTelefono='" + empresa.cTelefono + "', " +
                                        "vCorreo='" + empresa.vCorreo + "', " +
                                        "bVigencia=" + empresa.bVigencia + "" +
                                        " where Id_Empresa=" + empresa.Id_Empresa;

                conectaBD.abrirConexion();

                SqlCommand cmd = new SqlCommand(queryModifica, conectaBD.Conexion);

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
        public bool eliminarEmpresa(Empresa empresa)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryElimina = "UPDATE TBL_Empresa set bVigencia=" + empresa.bVigencia + " where Id_Empresa=" + empresa.Id_Empresa;

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
        public List<Empresa> ReporteEmpresa(Empresa empresa)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryBuscar = "SELECT " +
                                        "Id_Empresa," +
                                        "iRut," +
                                        "cDv," +
                                        "cNombre," +
                                        "cDireccion," +
                                        "cTelefono," +
                                        "vCorreo," +
                                        "dFechaCreacion " +
                                        "from " +
                                        "TBL_Empresa " +
                                        "where " +
                                        "dFechaCreacion >='" + empresa.dFechaDesde + "'" +
                                        "dFechaCreacion <='" + empresa.dFechaHasta + "'";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryBuscar, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Empresa> lista = new List<Empresa>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Empresa agregar = new Empresa();

                        agregar.Id_Empresa = int.Parse(dt.Rows[i][0].ToString());
                        agregar.iRut = int.Parse(dt.Rows[i][1].ToString());
                        agregar.cDv = dt.Rows[i][2].ToString();
                        agregar.cNombre = dt.Rows[i][3].ToString();
                        agregar.cDireccion = dt.Rows[i][4].ToString();
                        agregar.cTelefono = dt.Rows[i][5].ToString();
                        agregar.vCorreo = dt.Rows[i][6].ToString();
                        agregar.dFechaCreacion = Convert.ToDateTime(dt.Rows[i][7].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Empresa>();
                }
            }
            catch (Exception ex)
            {
                return new List<Empresa>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
    }
}
