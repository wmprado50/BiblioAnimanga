using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class datUsuario
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datUsuario _instancia = new datUsuario();
        //privado para evitar la instanciación directa
        public static datUsuario Instancia
        {
            get
            {
                return datUsuario._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //Listar Usuario
        public List<entUsuario> ListarUsuario()
        {
            SqlCommand cmd = null;
            List<entUsuario> lista = new List<entUsuario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarUsuarios", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entUsuario Us = new entUsuario();
                    Us.idUsuario = Convert.ToInt32(dr["idUsuario"]);
                    Us.nombreloginUs = dr["nombreloginUs"].ToString();
                    Us.contraseña = dr["contraseñaUs"].ToString();
                    Us.nombreUs = dr["nombreUs"].ToString();
                    Us.apellidoUs = dr["apellidoUs"].ToString();
                    Us.correoUs = dr["correoUs"].ToString();
                    Us.telefonoUs = Convert.ToInt32(dr["telefonoUs"]);
                    Us.estadoUs = Convert.ToBoolean(dr["estadoUs"]);



                    lista.Add(Us);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        //Insertar Usuario
        public Boolean InsertarUsuario(entUsuario Us)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreloginUs", Us.nombreloginUs);
                cmd.Parameters.AddWithValue("@contraseñaUs", Us.contraseña);
                cmd.Parameters.AddWithValue("@nombreUs", Us.nombreUs);
                cmd.Parameters.AddWithValue("@apellidoUs", Us.apellidoUs);
                cmd.Parameters.AddWithValue("@correoUs", Us.correoUs);
                cmd.Parameters.AddWithValue("@telefonoUs", Us.telefonoUs);
                cmd.Parameters.AddWithValue("@estadoUs", Us.estadoUs);


                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        //Editar Usuario
        public Boolean EditarUsuario(entUsuario Us)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombreloginUs", Us.nombreloginUs);
                cmd.Parameters.AddWithValue("@contraseñaUs", Us.contraseña);
                cmd.Parameters.AddWithValue("@nombreUs", Us.nombreUs);
                cmd.Parameters.AddWithValue("@apellidoUs", Us.apellidoUs);
                cmd.Parameters.AddWithValue("@correoUs", Us.correoUs);
                cmd.Parameters.AddWithValue("@telefonoUs", Us.telefonoUs);
                cmd.Parameters.AddWithValue("@estadoUs", Us.estadoUs);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        //Deshabilitar Usuario
        public Boolean DeshabilitarUsuario(entUsuario Us)
        {
            SqlCommand cmd = null;
            Boolean delete = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idUsuario", Us.idUsuario);

                cn.Open();

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }

            return delete;
        }
        #endregion metodos



    }
}
