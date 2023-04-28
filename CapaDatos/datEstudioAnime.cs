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
    public class datEstudioAnime
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datEstudioAnime _instancia = new datEstudioAnime();
        //privado para evitar la instanciación directa
        public static datEstudioAnime Instancia
        {
            get
            {
                return datEstudioAnime._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //Listar EstudioAnime 
        public List<entEstudioAnime> ListarEstudioAnime()
        {
            SqlCommand cmd = null;
            List<entEstudioAnime> lista = new List<entEstudioAnime>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarEstudioAnime", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEstudioAnime genAni = new entEstudioAnime();
                    genAni.id_estAni = Convert.ToInt32(dr["idestudioAni"]);
                    genAni.nombre_estAni = dr["nombre_estAni"].ToString();
                    genAni.descripcion_estAni = dr["descripcion_estAni"].ToString();
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
        //Insertar EstudioAnime
        public Boolean InsertarEstudioAnime(entEstudioAnime genAni)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarEstudioAnime", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_estAni", genAni.nombre_estAni);
                cmd.Parameters.AddWithValue("@desc_estAni", genAni.descripcion_estAni);
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
        //Editar EstudioAnime
        public Boolean EditarEstudioAnime(entEstudioAnime genAni)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarEstudioAnime", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idestudioAni", genAni.id_estAni);
                cmd.Parameters.AddWithValue("@nombre_estAni", genAni.nombre_estAni);
                cmd.Parameters.AddWithValue("@descripcion_estAni", genAni.descripcion_estAni);
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
        //Eliminar EstudioAnime
        public Boolean EliminarEstudioAnime(entEstudioAnime genAni)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarEstudioAnime", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idestudioAni", genAni.id_estAni);
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
