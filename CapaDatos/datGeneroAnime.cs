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
    public class datGeneroAnime
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datGeneroAnime _instancia = new datGeneroAnime();
        //privado para evitar la instanciación directa
        public static datGeneroAnime Instancia
        {
            get
            {
                return datGeneroAnime._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //Listar GeneroAnime 
        public List<entGeneroAnime> ListarGeneroAnime()
        {
            SqlCommand cmd = null;
            List<entGeneroAnime> lista = new List<entGeneroAnime>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarGeneroAnime", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entGeneroAnime genAni = new entGeneroAnime();
                    genAni.id_genAni = Convert.ToInt32(dr["idgeneroAni"]);
                    genAni.nombre_genAni = dr["nombre_genAni"].ToString();
                    genAni.descripcion_genAni = dr["descripcion_genAni"].ToString();
                    lista.Add(genAni);
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
        //Insertar GeneroAnime
        public Boolean InsertarGeneroAnime (entGeneroAnime genAni)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarGeneroAnime", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_genAni", genAni.nombre_genAni);
                cmd.Parameters.AddWithValue("@desc_genAni", genAni.descripcion_genAni);
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
        //Editar GeneroAnime
        public Boolean EditarGeneroAnime(entGeneroAnime genAni)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarGeneroAnime", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idgeneroAni", genAni.id_genAni);
                cmd.Parameters.AddWithValue("@nombre_genAni", genAni.nombre_genAni);
                cmd.Parameters.AddWithValue("@descripcion_genAni", genAni.descripcion_genAni);
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
        //Eliminar GeneroAnime
        public Boolean EliminarGeneroAnime(entGeneroAnime genAni)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarGeneroAnime", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idgeneroAni", genAni.id_genAni);
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
