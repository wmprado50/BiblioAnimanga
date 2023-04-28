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
    public class datAutorManga
    {

        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datAutorManga _instancia = new datAutorManga();
        //privado para evitar la instanciación directa
        public static datAutorManga Instancia
        {
            get
            {
                return datAutorManga._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //Listar AutorManga 
        public List<entAutorManga> ListarAutorManga()
        {
            SqlCommand cmd = null;
            List<entAutorManga> lista = new List<entAutorManga>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarAutorManga", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entAutorManga autMan = new entAutorManga();
                    autMan.id_autorMan = Convert.ToInt32(dr["idautorMan"]);
                    autMan.nombre_autorMan = dr["nombre_autMan"].ToString();
                    autMan.descripcion_autorMan = dr["descripcion_autMan"].ToString();
                    lista.Add(autMan);
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
        //Insertar AutorManga
        public Boolean InsertarAutorManga(entAutorManga autMan)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarAutorManga", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_autMan", autMan.nombre_autorMan);
                cmd.Parameters.AddWithValue("@desc_autMan", autMan.descripcion_autorMan);
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
        //Editar AutorManga
        public Boolean EditarAutorManga(entAutorManga autMan)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarAutorManga", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idautorMan", autMan.id_autorMan);
                cmd.Parameters.AddWithValue("@nombre_autMan", autMan.nombre_autorMan);
                cmd.Parameters.AddWithValue("@descripcion_autMan", autMan.descripcion_autorMan);
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
        //Eliminar AutorManga
        public Boolean EliminarAutorManga(entAutorManga autMan)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarAutorManga", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idautorMan", autMan.id_autorMan);
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
