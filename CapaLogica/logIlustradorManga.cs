using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logIlustradorManga
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logIlustradorManga _instancia = new logIlustradorManga();
        //privado para evitar la instanciación directa
        public static logIlustradorManga Instancia
        {
            get
            {
                return logIlustradorManga._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //Listar
        public List<entIlustradorManga> ListarIlustradorManga()
        {
            return datIlustradorManga.Instancia.ListarIlustradorManga();
        }

        ///Insertar
        public void InsertarIlustradorManga(entIlustradorManga iluMan)
        {
            datIlustradorManga.Instancia.InsertarIlustradorManga(iluMan);
        }

        //Editar
        public void EditarIlustradorManga(entIlustradorManga iluMan)
        {
            datIlustradorManga.Instancia.EditarIlustradorManga(iluMan);
        }

        public void EliminarIlustradorManga(entIlustradorManga iluMan)
        {
            datIlustradorManga.Instancia.EliminarIlustradorManga(iluMan);
        }

        #endregion metodos




    }
}
