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
    public class ConsultaFormaPago
    {
        public List<FormaPago> ConsutaFormaPago(FormaPago formaPago)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryConsulta = "SELECT Id_FormaPago,cNombre,bVigencia from TBL_FormaPago";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryConsulta, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<FormaPago> lista = new List<FormaPago>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        FormaPago agregar = new FormaPago();

                        agregar.Id_FormaPago = int.Parse(dt.Rows[i][0].ToString());
                        agregar.cNombre = dt.Rows[i][1].ToString();
                        agregar.bVigencia = int.Parse(dt.Rows[i][2].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<FormaPago>();
                }
            }
            catch (Exception ex)
            {
                return new List<FormaPago>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public List<FormaPago> BuscarFormaPago(FormaPago formaPago)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryBuscar = "SELECT Id_FormaPago,cNombre,bVigencia from TBL_FormaPago where Id_FormaPago=" + formaPago.Id_FormaPago;

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryBuscar, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<FormaPago> lista = new List<FormaPago>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        FormaPago agregar = new FormaPago();

                        agregar.Id_FormaPago = int.Parse(dt.Rows[i][0].ToString());
                        agregar.cNombre = dt.Rows[i][1].ToString();
                        agregar.bVigencia = int.Parse(dt.Rows[i][2].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<FormaPago>();
                }
            }
            catch (Exception ex)
            {
                return new List<FormaPago>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public bool registraFormaPago(FormaPago formaPago)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryInsert = "INSERT INTO TBL_FormaPago VALUES ('" +
                                     formaPago.cNombre + "'," +
                                     formaPago.bVigencia + ");";

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
        public bool modificarFormaPago(FormaPago formaPago)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryModifica = "UPDATE TBL_FormaPago set cNombre='" + formaPago.cNombre + "', bVigencia=" + formaPago.bVigencia + " where Id_FormaPago=" + formaPago.Id_FormaPago;

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
        public bool eliminarFormaPago(FormaPago formaPago)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryElimina = "UPDATE TBL_FormaPago set bVigencia=" + formaPago.bVigencia + " where Id_FormaPago=" + formaPago.Id_FormaPago;

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
