using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
//Clase para mapear datos de la tabla localizacion del esquema localizacion
namespace Utilidades.Localizacion
{
    [Serializable]
    [Table("usuario", Schema = "usuarios")]
    public class Localizacion
    {
        private int id;
        private string departamento;
        private string ciudad;
        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("departamento")]
        public string Departamento { get => departamento; set => departamento = value; }
        [Column("ciudad")]
        public string Ciudad { get => ciudad; set => ciudad = value; }
    }
}
