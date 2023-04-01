using System;
using System.ComponentModel.DataAnnotations;

namespace PracticaMvc.Models
{
	public class Marcas
	{
        [Key]
        [Display(Name = "ID")]
        public int id_marcas { get; set; }
        [Display(Name = "NOMBRE")]

        public string? nombre_marca { get; set; }
        [Display(Name = "ESTADO")]

        public string? estados { get; set; }

    }
}

