using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logAnime
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logAnime _instancia = new logAnime ();
        //privado para evitar la instanciación directa
        public static logAnime Instancia
        {
            get
            {
                return logAnime._instancia;
            }
        }
        #endregion singleton


        #region metodos
        //Listar
        public List<entAnime> ListarAnime()
        {
            return datAnime.Instancia.ListarAnime();
        }

        ///Insertar
        public void InsertarAnime(entAnime Ani)
        {
            datAnime.Instancia.InsertarAnime(Ani);
        }

        //Editar
        public void EditarAnime(entAnime Ani)
        {
            datAnime.Instancia.EditarAnime(Ani);
        }

        public void EliminarAnime(entAnime Ani)
        {
            datAnime.Instancia.EliminarAnime(Ani);
        }

        #endregion metodos


    }
}
