using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilidadesLibreria.Cliente;
using UtilidadesLibreria.Localizacion;
using DatosLibreria;
namespace LogicaNegocioLibreria
{
    /// <summary>
    /// Clase puente para comunicar los datos con la clase de servicios
    /// </summary>
   public class Registro
    {
       private DatosLibreria.Registro GetRegistro = new DatosLibreria.Registro();
        /// <summary>
        /// Llama a la libreria de datos para obtener los departamentos
        /// </summary>
        /// <returns>devuelve una lista con el id del departamento y el nombre del mismo</returns>
        public List<Localizacion> GetDepartamento()
        {
            return GetRegistro.GetDepartamento();
        }
        /// <summary>
        /// Llama a la libreria de datos para obtener las ciudades
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Un json con las ciudades del departamento deseado</returns>
        public List<Ciudades> GetCiudad(int id)
        {
            return GetRegistro.GetCiudad(id);
        }
        /// <summary>
        /// Llama a la libreria de datos para insertar los clientes
        /// </summary>
        /// <param name="cliente"> Cliente completo para insertar</param>
        public string InsertarRegistro(Cliente cliente)
        {
            return GetRegistro.InsertarRegistro(cliente);
        }
    }
}
