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
    public class ConsultaUsers
    {
        public bool ConsutaLogin(Users usuario)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryInsert = "SELECT Id_Usuario from [TALLER-NET].[dbo].[TBL_Usuario] where cNombreUsuario = '" + usuario.user + "' and cClave = '" + usuario.password + "'";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryInsert, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);


                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
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
