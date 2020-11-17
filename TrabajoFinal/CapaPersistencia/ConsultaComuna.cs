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
    public class ConsultaComuna
    {
        public List<Comuna> ConsutaComuna(Comuna comuna)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryConsulta = "SELECT Id_Comuna,Id_Ciudad,cNombre,bVigencia from TBL_Comuna";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryConsulta, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Comuna> lista = new List<Comuna>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Comuna agregar = new Comuna();

                        agregar.Id_Comuna = int.Parse(dt.Rows[i][0].ToString());
                        agregar.Id_Ciudad = int.Parse(dt.Rows[i][1].ToString());
                        agregar.cNombre = dt.Rows[i][2].ToString();
                        agregar.bVigencia = int.Parse(dt.Rows[i][3].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Comuna>();
                }
            }
            catch (Exception ex)
            {
                return new List<Comuna>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public List<Comuna> BuscarComuna(Comuna comuna)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryBuscar = "SELECT Id_Comuna,Id_Ciudad,cNombre,bVigencia from TBL_Comuna where Id_Ciudad=" + comuna.Id_Ciudad;

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryBuscar, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Comuna> lista = new List<Comuna>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Comuna agregar = new Comuna();

                        agregar.Id_Comuna = int.Parse(dt.Rows[i][0].ToString());
                        agregar.Id_Ciudad = int.Parse(dt.Rows[i][1].ToString());
                        agregar.cNombre = dt.Rows[i][2].ToString();
                        //agregar.bVigencia = int.Parse(dt.Rows[i][3].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Comuna>();
                }
            }
            catch (Exception ex)
            {
                return new List<Comuna>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public bool registraComuna(Comuna comuna)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryInsert = "INSERT INTO TBL_Comuna VALUES (" +
                                     comuna.Id_Ciudad + ",'" +
                                     comuna.cNombre + "'," +
                                     comuna.bVigencia + ");";

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
        public bool modificarComuna(Comuna comuna)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryModifica = "UPDATE TBL_Comuna set cNombre='" + comuna.cNombre + "', Id_Ciudad=" + comuna.Id_Ciudad + ", bVigencia=" + comuna.bVigencia + " where Id_Comuna=" + comuna.Id_Comuna;

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
        public bool eliminarComuna(Comuna comuna)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryElimina = "UPDATE TBL_Comuna set bVigencia=" + comuna.bVigencia + " where Id_Comuna=" + comuna.Id_Comuna;

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
    }
}
