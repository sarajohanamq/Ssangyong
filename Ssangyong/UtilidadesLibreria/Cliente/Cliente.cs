using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilidadesLibreria.Cliente
{
  
        [Serializable]
        [Table("cliente", Schema = "cliente")]
        /// <summary>
        /// Clase que mapea la tabla cliente en el esquema cliente de la base de datos
        /// </summary>
    public class Cliente
        {
            private int id;
            private string nombre;
            private string email;
            private long telefono;
            private string localizacion_user;
            private DateTime fecha;
            private string modelo;
            private string departamento;
            private string ciudad;

            // Columnas mapeadas por base de datos cliente
            [Key]
            [Column("id")]
            public int Id { get => id; set => id = value; }
            [Column("nombre")]
            public string Nombre { get => nombre; set => nombre = value; }
            [Column("email")]
            public string Email { get => email; set => email = value; }
            [Column("telefono")]
            public long Telefono { get => telefono; set => telefono = value; }
            [Column("localizacion_user")]
            public string Localizacion_user { get => localizacion_user; set => localizacion_user = value; }
            [Column("fecha")]
            public DateTime Fecha { get => fecha; set => fecha = value; }
            [Column("modelo")]
            public string Modelo { get => modelo; set => modelo = value; }
             // datos obtenidos de de la tabla localizacion
            [NotMapped]
            public string Departamento { get => departamento; set => departamento = value; }
            [NotMapped]
            public string Ciudad { get => ciudad; set => ciudad = value; }
      
    }
    
}
