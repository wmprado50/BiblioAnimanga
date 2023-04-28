using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logEstudioAnime
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logEstudioAnime _instancia = new logEstudioAnime();
        //privado para evitar la instanciación directa
        public static logEstudioAnime Instancia
        {
            get
            {
                return logEstudioAnime._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //Listar
        public List<entEstudioAnime> ListarEstudioAnime()
        {
            return datEstudioAnime.Instancia.ListarEstudioAnime();
        }

        ///Insertar
        public void InsertarEstudioAnime(entEstudioAnime estAni)
        {
            datEstudioAnime.Instancia.InsertarEstudioAnime(estAni);
        }

        //Editar
        public void EditarEstudioAnime(entEstudioAnime estAni)
        {
            datEstudioAnime.Instancia.EditarEstudioAnime(estAni);
        }

        public void EliminarEstudioAnime(entEstudioAnime estAni)
        {
            datEstudioAnime.Instancia.EliminarEstudioAnime(estAni);
        }

        #endregion metodos



    }
}
