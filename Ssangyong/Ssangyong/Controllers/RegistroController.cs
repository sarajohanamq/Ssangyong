using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UtilidadesLibreria.Cliente;
using UtilidadesLibreria.Localizacion;
using LogicaNegocioLibreria;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using System.Threading.Tasks;

namespace Ssangyong.Controllers
{
    [AllowAnonymous]
    [EnableCors("*", "*", "*")]
    public class RegistroController : ApiController
    {
        private LogicaNegocioLibreria.Registro GetRegistro = new LogicaNegocioLibreria.Registro();
        /// <summary>
        /// Llama a la logica de negocio para obtener los departamentos
        /// </summary>
        /// <returns>devuelve una lista con el id del departamento y el nombre del mismo</returns>
        [HttpGet]
        [ResponseType(typeof(List<Localizacion>))]
        public IHttpActionResult GetDepartamento()
        {
           
            try
            {
                List<Localizacion> localizacions = GetRegistro.GetDepartamento();
                return Ok(localizacions);
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
            
        }
        /// <summary>
        ///Llama a la logica de negocio para obtener las ciudades
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Un json con las ciudades del departamento deseado</returns>
        [HttpGet]
        [ResponseType(typeof(List<Ciudades>))]
        public IHttpActionResult GetCiudad(int id)
        {
           
            try
            {
                List<Ciudades> ciudades = GetRegistro.GetCiudad(id);
              
                return Ok(ciudades);
                
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        /// <summary>
        /// Llama a la logica de negocio para insertar los clientes
        /// </summary>
        /// <param name="cliente"> Cliente completo para insertar</param>
        [HttpPost]
        public IHttpActionResult InsertarRegistro([FromBody] Cliente cliente)
        {
            try
            {
                cliente.Fecha = DateTime.Now;
                string mensaje = GetRegistro.InsertarRegistro(cliente);
                if (mensaje.Equals("conflict"))
                {
                    return Conflict();
                }
                return Ok();

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
                
            }
          
        }
    }
}
