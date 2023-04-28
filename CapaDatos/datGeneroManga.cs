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
    public class datGeneroManga
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datGeneroManga _instancia = new datGeneroManga();
        //privado para evitar la instanciación directa
        public static datGeneroManga Instancia
        {
            get
            {
                return datGeneroManga._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //Listar GeneroManga 
        public List<entGeneroManga> ListarGeneroManga()
        {
            SqlCommand cmd = null;
            List<entGeneroManga> lista = new List<entGeneroManga>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarGeneroManga", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entGeneroManga genMan = new entGeneroManga();
                    genMan.id_genMan = Convert.ToInt32(dr["idgeneroMan"]);
                    genMan.nombre_genMan = dr["nombre_genMan"].ToString();
                    genMan.descripcion_genMan = dr["descripcion"].ToString();
                    lista.Add(genMan);
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
        //Insertar GeneroManga
        public Boolean InsertarGeneroManga(entGeneroManga genMan)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarGeneroManga", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_genMan", genMan.nombre_genMan);
                cmd.Parameters.AddWithValue("@desc_genMan", genMan.descripcion_genMan);
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
        //Editar GeneroManga
        public Boolean EditarGeneroManga(entGeneroManga genMan)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarGeneroManga", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idgeneroMan", genMan.id_genMan);
                cmd.Parameters.AddWithValue("@nombre_genMan", genMan.nombre_genMan);
                cmd.Parameters.AddWithValue("@descripcion", genMan.descripcion_genMan);
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
        //Eliminar GeneroManga
        public Boolean EliminarGeneroManga(entGeneroManga genMan)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarGeneroManga", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idgeneroMan", genMan.id_genMan);
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
