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
    public class ConsultaCiudad
    {
        public List<Ciudad> ConsutaCiudad(Ciudad ciudad)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryConsulta = "SELECT Id_Ciudad,cNombre,bVigencia from TBL_Ciudad";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryConsulta, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Ciudad> lista = new List<Ciudad>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Ciudad agregar = new Ciudad();

                        agregar.Id_Ciudad = int.Parse(dt.Rows[i][0].ToString());
                        agregar.cNombre = dt.Rows[i][1].ToString();
                        //agregar.bVigencia = int.Parse(dt.Rows[i][2].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Ciudad>();
                }
            }
            catch (Exception ex)
            {
                return new List<Ciudad>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public List<Ciudad> BuscarCiudad(Ciudad ciudad)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryBuscar = "SELECT Id_Ciudad,cNombre,bVigencia from TBL_Ciudad where Id_Ciudad=" + ciudad.Id_Ciudad;

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryBuscar, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Ciudad> lista = new List<Ciudad>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Ciudad agregar = new Ciudad();

                        agregar.Id_Ciudad = int.Parse(dt.Rows[i][0].ToString());
                        agregar.cNombre = dt.Rows[i][1].ToString();
                        agregar.bVigencia = int.Parse(dt.Rows[i][2].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Ciudad>();
                }
            }
            catch (Exception ex)
            {
                return new List<Ciudad>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public bool registraCiudad(Ciudad ciudad)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryInsert = "INSERT INTO TBL_Ciudad VALUES ('" +
                                     ciudad.cNombre + "'," +
                                     ciudad.bVigencia + ");";

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
        public bool modificarCiudad(Ciudad ciudad)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryModifica = "UPDATE TBL_Ciudad set cNombre='" + ciudad.cNombre + "', bVigencia=" + ciudad.bVigencia + " where Id_Ciudad=" + ciudad.Id_Ciudad;

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
        public bool eliminarCiudad(Ciudad ciudad)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryElimina = "UPDATE TBL_Ciudad set bVigencia=" + ciudad.bVigencia + " where Id_Ciudad=" + ciudad.Id_Ciudad;

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
