using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace HtmlHelper.Models
{
    public class Datos
    {

        [ScaffoldColumn(false)]

        [Required]
        public string Nombre { get; set; }

        [Required]
        public int Cedula { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        [Range(16, 100, ErrorMessage = "Debe ser mayor de 15")]
        public int Edad { get; set; }
   
        public int Telefono { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }


        public GeneroRef Genero { get; set; }
        public EstadoRef Estado { get; set; }

        public bool Jugar { get; set; }
        public bool Ajedrez { get; set; }
        public bool Ejercitarse { get; set; }
        public bool Pintar { get; set; }

    }

    /*  enum es un tipo de datos de tipo de valor.
    La enumeración se utiliza para declarar una lista de constantes enteras nombradas.*/
    public enum GeneroRef
    {
        Masculino,
        Femenino
        
    }
    public enum EstadoRef
    {
        Casado,
        Soltero,
        Viudo,
        UnionLibre
    }
}