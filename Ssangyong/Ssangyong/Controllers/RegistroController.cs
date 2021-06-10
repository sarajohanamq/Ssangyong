using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UtilidadesLibreria.Cliente;
using UtilidadesLibreria.Localizacion;
using LogicaNegocioLibreria;
namespace Ssangyong.Controllers
{
    [AllowAnonymous]
    public class RegistroController : ApiController
    {
        private LogicaNegocioLibreria.Registro GetRegistro = new LogicaNegocioLibreria.Registro();
        /// <summary>
        /// Llama a la logica de negocio para obtener los departamentos
        /// </summary>
        /// <returns>devuelve una lista con el id del departamento y el nombre del mismo</returns>
        [HttpGet]
        public List<Localizacion> GetDepartamento()
        {
            return GetRegistro.GetDepartamento();
        }
        /// <summary>
        ///Llama a la logica de negocio para obtener las ciudades
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Un json con las ciudades del departamento deseado</returns>
        [HttpGet]
        public List<string> GetCiudad(int id)
        {
            return GetRegistro.GetCiudad(id);
        }
        /// <summary>
        /// Llama a la logica de negocio para insertar los clientes
        /// </summary>
        /// <param name="cliente"> Cliente completo para insertar</param>
        [HttpPost]
        public void InsertarRegistro(Cliente cliente)
        {
            GetRegistro.InsertarRegistro(cliente);
        }
    }
}
