using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilidadesLibreria.Cliente;
using UtilidadesLibreria.Localizacion;

namespace DatosLibreria
{
    /// <summary>
    /// Clase que se conecta con la base de datos para realizar las transacciones respectivas
    /// </summary>
    public class Registro
    {
        private Mapeo db = new Mapeo();
        /// <summary>
        /// filtra la lista completa de la base de datos para mostrar solo el departamento
        /// </summary>
        /// <returns>devuelve una lista con el id del departamento y el nombre del mismo</returns>
        public List<Localizacion> GetDepartamento()
        {
            List<Localizacion> localizacion = db.localizacion.ToList();
            List<Localizacion> departamentos = null;
            foreach (Localizacion departamento in localizacion)
            {
                Localizacion dep = null;
                dep.Departamento = departamento.Departamento;
                dep.Id = departamento.Id;
                departamentos.Add(dep);
            }
            return departamentos;
        }
        /// <summary>
        /// Obtiene las ciudades del respectivo departamento
        /// </summary>
        /// <param name="id">id del departamento a buscar</param>
        /// <returns>Un json con las ciudades del departamento deseado</returns>
        public List<string> GetCiudad(int id)
        {
            return JsonConvert.DeserializeObject<List<string>>(db.localizacion.Where(x => x.Id == id).First().Ciudad);
        }
        /// <summary>
        /// Inserta el registro del cliente
        /// </summary>
        /// <param name="cliente"> Cliente completo para insertar</param>
        public void InsertarRegistro(Cliente cliente)
        {
            db.clientes.Add(cliente);
            db.SaveChanges();
        }
    }
}
