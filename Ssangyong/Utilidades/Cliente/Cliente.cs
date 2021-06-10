using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
//Clase para mapear datos de la tabla cliente del esquema cliente
namespace Utilidades.Cliente
{
    [Serializable]
    [Table("usuario", Schema = "usuarios")]
    public class Cliente
    {
        private int id;
        private string nombre;
        private string email;
        private long telefono;
        private string localizacion_user; 
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

        // datos obtenidos por foreing key de la tabla localizacion
        [NotMapped]
        public string Departamento { get => departamento; set => departamento = value; }
        [NotMapped]
        public string Ciudad { get => ciudad; set => ciudad = value; }
    }
}
