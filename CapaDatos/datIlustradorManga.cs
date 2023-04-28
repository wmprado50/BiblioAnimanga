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
    public class datIlustradorManga
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datIlustradorManga _instancia = new datIlustradorManga();
        //privado para evitar la instanciación directa
        public static datIlustradorManga Instancia
        {
            get
            {
                return datIlustradorManga._instancia;
            }
        }
        #endregion singleton


        #region metodos
        //Listar IlustradorManga 
        public List<entIlustradorManga> ListarIlustradorManga()
        {
            SqlCommand cmd = null;
            List<entIlustradorManga> lista = new List<entIlustradorManga>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarIlustradorManga", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entIlustradorManga iluMan = new entIlustradorManga();
                    iluMan.id_ilustMan = Convert.ToInt32(dr["idilustMan"]);
                    iluMan.nombre_iluMan = dr["nombre_iluMan"].ToString();
                    iluMan.descripcion_iluMan = dr["descripcion_iluMan"].ToString();
                    lista.Add(iluMan);
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
        //Insertar IlustradorManga
        public Boolean InsertarIlustradorManga(entIlustradorManga iluMan)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarIlustradorManga", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_iluMan", iluMan.nombre_iluMan);
                cmd.Parameters.AddWithValue("@desc_iluMan", iluMan.descripcion_iluMan);
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
        //Editar IlustradorManga
        public Boolean EditarIlustradorManga(entIlustradorManga iluMan)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarIlustradorManga", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idilustMan", iluMan.id_ilustMan);
                cmd.Parameters.AddWithValue("@nombre_iluMan", iluMan.nombre_iluMan);
                cmd.Parameters.AddWithValue("@descripcion_iluMan", iluMan.descripcion_iluMan);
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
        //Eliminar IlustradorManga
        public Boolean EliminarIlustradorManga(entIlustradorManga iluMan)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarIlustradorManga", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idulustMan", iluMan.id_ilustMan);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return elimina;
        }
        #endregion metodos

    }
}
