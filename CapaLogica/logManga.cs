using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logManga
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logManga _instancia = new logManga();
        //privado para evitar la instanciación directa
        public static logManga Instancia
        {
            get
            {
                return logManga._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //Listar
        public List<entManga> ListarManga()
        {
            return datManga.Instancia.ListarManga();
        }

        ///Insertar
        public void InsertarManga(entManga Man)
        {
            datManga.Instancia.InsertarManga(Man);
        }

        //Editar
        public void EditarManga(entManga Man)
        {
            datManga.Instancia.EditarManga(Man);
        }

        public void EliminarManga(entManga Man)
        {
            datManga.Instancia.EliminarManga(Man);
        }

        #endregion metodos




    }
}
