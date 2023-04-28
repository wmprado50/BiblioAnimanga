using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;


namespace CapaLogica
{
    public class logUsuario
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logUsuario _instancia = new logUsuario();
        //privado para evitar la instanciación directa
        public static logUsuario Instancia
        {
            get
            {
                return logUsuario._instancia;
            }
        }
        #endregion singleton


        #region metodos
        //Listar
        public List<entUsuario> ListarUsuario()
        {
            return datUsuario.Instancia.ListarUsuario();
        }

        ///Insertar
        public void InsertarUsuario(entUsuario Us)
        {
            datUsuario.Instancia.InsertarUsuario(Us);
        }

        //Editar
        public void EditarUsuario(entUsuario Us)
        {
            datUsuario.Instancia.EditarUsuario(Us);
        }

        public void DeshabilitarUsuario(entUsuario Us)
        {
            datUsuario.Instancia.DeshabilitarUsuario(Us);
        }

        #endregion metodos



    }
}
