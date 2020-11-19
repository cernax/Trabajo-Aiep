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
    public class ConsultaCliente
    {
        public List<Cliente> ConsutaCliente(Cliente Cliente)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryConsulta = "SELECT " +
                                        "a.Id_Cliente," +
                                        "a.iRut," +
                                        "a.cDv," +
                                        "a.cNombres," +
                                        "a.cApellidos," +
                                        "a.Id_Ciudad," +
                                        "b.cNombre," +
                                        "a.Id_Comuna," +
                                        "c.cNombre," +
                                        "a.cDireccion," +
                                        "a.cTelefono," +
                                        "a.vCorreo," +
                                        "a.dFechaNacimiento," +
                                        "a.dFechaCreacion " +
                                        "from " +
                                        "TBL_Cliente a " +
                                        "inner join TBL_Ciudad  b " +
                                        "on a.Id_Ciudad = b.Id_Ciudad " +
                                        "inner join TBL_Comuna  c " +
                                        "on a.Id_Ciudad = c.Id_Ciudad " +
                                        "and a.Id_Comuna = c.Id_Comuna ";
                
                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryConsulta, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Cliente> lista = new List<Cliente>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Cliente agregar = new Cliente();

                        agregar.Id_Cliente = int.Parse(dt.Rows[i][0].ToString());
                        agregar.iRut = int.Parse(dt.Rows[i][1].ToString());
                        agregar.cDv = dt.Rows[i][2].ToString();
                        agregar.cNombres = dt.Rows[i][3].ToString();
                        agregar.cApellidos = dt.Rows[i][4].ToString();
                        agregar.Id_Ciudad = int.Parse(dt.Rows[i][5].ToString());
                        agregar.cCiudad = dt.Rows[i][6].ToString();
                        agregar.Id_Comuna = int.Parse(dt.Rows[i][7].ToString());
                        agregar.cComuna = dt.Rows[i][8].ToString();
                        agregar.cDireccion = dt.Rows[i][9].ToString();
                        agregar.cTelefono = dt.Rows[i][10].ToString();
                        agregar.vCorreo = dt.Rows[i][11].ToString();
                        agregar.dFechaNacimiento = Convert.ToDateTime(dt.Rows[i][12].ToString());
                        agregar.dFechaCreacion = Convert.ToDateTime(dt.Rows[i][13].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Cliente>();
                }
            }
            catch (Exception ex)
            {
                return new List<Cliente>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public List<Cliente> BuscarCliente(Cliente cliente)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryBuscar = "SELECT " +
                                     "Id_Cliente," +
                                     "iRut," +
                                     "cDv," +
                                     "cNombres," +
                                     "cApellidos," +
                                     "Id_Ciudad," +
                                     "Id_Comuna," +
                                     "cDireccion," +
                                     "cTelefono," +
                                     "vCorreo," +
                                     "dFechaNacimiento," +
                                     "dFechaCreacion " +
                                     "from " +
                                     "TBL_Cliente " +
                                     "where " +
                                     "Id_Cliente=" + cliente.Id_Cliente;

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryBuscar, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Cliente> lista = new List<Cliente>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Cliente agregar = new Cliente();

                        agregar.Id_Cliente = int.Parse(dt.Rows[i][0].ToString());
                        agregar.iRut = int.Parse(dt.Rows[i][1].ToString());
                        agregar.cDv = dt.Rows[i][2].ToString();
                        agregar.cNombres = dt.Rows[i][3].ToString();
                        agregar.cApellidos = dt.Rows[i][4].ToString();
                        agregar.Id_Ciudad = int.Parse(dt.Rows[i][5].ToString());
                        agregar.Id_Comuna = int.Parse(dt.Rows[i][6].ToString());
                        agregar.cDireccion = dt.Rows[i][7].ToString();
                        agregar.cTelefono = dt.Rows[i][8].ToString();
                        agregar.vCorreo = dt.Rows[i][9].ToString();
                        agregar.dFechaNacimiento = Convert.ToDateTime(dt.Rows[i][10].ToString());
                        agregar.dFechaCreacion = Convert.ToDateTime(dt.Rows[i][11].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Cliente>();
                }
            }
            catch (Exception ex)
            {
                return new List<Cliente>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public bool registraCliente(Cliente cliente)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryInsert = "INSERT INTO TBL_Cliente " +
                                    "(" +
                                    "iRut, " +
                                    "cDv, " +
                                    "cNombres, " +
                                    "cApellidos, " +
                                    "Id_Ciudad," +
                                    "Id_Comuna, " +
                                    "cDireccion, " +
                                    "cTelefono, " +
                                    "vCorreo, " +
                                    "bVigencia," +
                                    "dFechaNacimiento," +
                                    "dFechaCreacion" +
                                    ") " +
                                    "VALUES " +
                                    "(" + 
                                    cliente.iRut + ",'" +
                                    cliente.cDv + "','" +
                                    cliente.cNombres + "','" +
                                    cliente.cApellidos + "'," +
                                    cliente.Id_Ciudad + "," +
                                    cliente.Id_Comuna + ",'" +
                                    cliente.cDireccion + "','" +
                                    cliente.cTelefono + "','" +
                                    cliente.vCorreo + "'," +
                                    cliente.bVigencia + ",'" +
                                    cliente.dFechaNacimiento.ToString("yyyy-MM-dd 00:00:00.000") + "', '" +
                                    cliente.dFechaCreacion.ToString("yyyy-MM-dd 00:00:00.000") +
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
        public bool modificarCliente(Cliente cliente)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryModifica = "UPDATE TBL_Cliente " +
                                        "set cNombres='" + cliente.cNombres + 
                                        "',cApellidos='" + cliente.cApellidos +
                                        "',Id_Ciudad=" + cliente.Id_Ciudad +
                                        ",Id_Comuna=" + cliente.Id_Comuna +
                                        ",cDireccion='" + cliente.cDireccion +
                                        ",cTelefono='" + cliente.cTelefono +
                                        ",vCorreo='" + cliente.vCorreo +
                                        "',dFechaNacimiento='" + cliente.dFechaNacimiento + 
                                        "' where Id_Cliente=" + cliente.Id_Cliente;

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
        public bool eliminarCliente(Cliente cliente)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryElimina =   "UPDATE " +
                                        "TBL_Cliente " +
                                        "set bVigencia=" + cliente.bVigencia + 
                                        " where Id_Cliente=" + cliente.Id_Cliente;

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

        public List<Cliente> ReporteCliente(Cliente cliente)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryBuscar = "SELECT " +
                                     "Id_Cliente," +
                                     "iRut," +
                                     "cDv," +
                                     "cNombres," +
                                     "cApellidos," +
                                     "Id_Ciudad," +
                                     "Id_Comuna," +
                                     "cDireccion," +
                                     "cTelefono," +
                                     "vCorreo," +
                                     "dFechaNacimiento," +
                                     "dFechaCreacion " +
                                     "from " +
                                     "TBL_Cliente " +
                                     "where " +
                                     "dFechaCreacion >='" + cliente.dFechaDesde + "'" +
                                     "dFechaCreacion <='" + cliente.dFechaHasta + "'";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryBuscar, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Cliente> lista = new List<Cliente>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Cliente agregar = new Cliente();

                        agregar.Id_Cliente = int.Parse(dt.Rows[i][0].ToString());
                        agregar.iRut = int.Parse(dt.Rows[i][1].ToString());
                        agregar.cDv = dt.Rows[i][2].ToString();
                        agregar.cNombres = dt.Rows[i][3].ToString();
                        agregar.cApellidos = dt.Rows[i][4].ToString();
                        agregar.Id_Ciudad = int.Parse(dt.Rows[i][5].ToString());
                        agregar.Id_Comuna = int.Parse(dt.Rows[i][6].ToString());
                        agregar.cDireccion = dt.Rows[i][7].ToString();
                        agregar.cTelefono = dt.Rows[i][8].ToString();
                        agregar.vCorreo = dt.Rows[i][9].ToString();
                        agregar.dFechaNacimiento = Convert.ToDateTime(dt.Rows[i][10].ToString());
                    agregar.dFechaCreacion = Convert.ToDateTime(dt.Rows[i][11].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Cliente>();
                }
            }
            catch (Exception ex)
            {
                return new List<Cliente>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
    }
}
