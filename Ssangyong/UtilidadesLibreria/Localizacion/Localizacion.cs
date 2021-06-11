using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UtilidadesLibreria.Localizacion
{
    [Serializable]
    [Table("localizacion", Schema = "localizacion")]
    /// <summary>
    /// Clase que mapea la tabla localizacion en el esquema localizacion de la base de datos
    /// </summary>
    public class Localizacion
    {
        private int id;
        private string departamento;
        private string ciudad;
        // Columnas mapeadas por base de datos localizacion
        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("departamento")]
        public string Departamento { get => departamento; set => departamento = value; }
        [Column("ciudad")]
        public string Ciudad { get => ciudad; set => ciudad = value; }
    }
}
