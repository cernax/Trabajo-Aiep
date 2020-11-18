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
    public class ConsultaProducto
    {
        public List<Producto> ConsutaProducto(Producto producto)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryConsulta = "SELECT Id_Producto,cNombre,iStock,iValor,bVigencia from TBL_Producto";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryConsulta, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Producto> lista = new List<Producto>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Producto agregar = new Producto();

                        agregar.Id_Producto = int.Parse(dt.Rows[i][0].ToString());
                        agregar.cNombre = dt.Rows[i][1].ToString();
                        agregar.iStock = int.Parse(dt.Rows[i][2].ToString());
                        agregar.iValor = int.Parse(dt.Rows[i][3].ToString().Split(',')[0]);
                        agregar.bVigencia = dt.Rows[i][4].ToString() == "true" ? 1 : 0;

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Producto>();
                }
            }
            catch (Exception ex)
            {
                return new List<Producto>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public List<Producto> BuscarProducto(Producto producto)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryBuscar = "SELECT Id_Producto,cNombre,iStock,iValor,bVigencia from TBL_Producto where Id_Producto=" + producto.Id_Producto;

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryBuscar, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Producto> lista = new List<Producto>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Producto agregar = new Producto();

                        agregar.Id_Producto = int.Parse(dt.Rows[i][0].ToString());
                        agregar.cNombre = dt.Rows[i][1].ToString();
                        agregar.iStock = int.Parse(dt.Rows[i][2].ToString());
                        agregar.iValor = int.Parse(dt.Rows[i][3].ToString());
                        agregar.bVigencia = int.Parse(dt.Rows[i][4].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Producto>();
                }
            }
            catch (Exception ex)
            {
                return new List<Producto>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public bool registraProducto(Producto producto)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryInsert = "INSERT INTO TBL_Producto VALUES ('" +
                                    producto.cNombre + "'," +
                                    producto.iStock + "," +
                                    producto.iValor + "," +
                                    producto.bVigencia + ");";

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
        public bool modificarProducto(Producto producto)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryModifica = "UPDATE TBL_Producto set cNombre='" + producto.cNombre + "', iStock=" + producto.iStock + "', iValor=" + producto.iValor + ", bVigencia=" + producto.bVigencia + " where Id_Producto=" + producto.Id_Producto;

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
        public bool eliminarProducto(Producto producto)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryElimina = "UPDATE TBL_Producto set bVigencia=" + producto.bVigencia + " where Id_Producto=" + producto.Id_Producto;

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
