using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using UtilidadesLibreria.Cliente;
using UtilidadesLibreria.Localizacion;

namespace DatosLibreria
{
    /// <summary>
    /// Clase que se conecta a la base de datos y encapsula los mapeos de las tablas
    /// </summary>
    class Mapeo : DbContext
    {
        public Mapeo() : base("name=owpartConexion") { }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Localizacion> localizacion { get; set; }
    }
}
