using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace U20240408.EntidadesDeNegocio
{
    public partial class PersonaU
    {
        public int Id { get; set; }

        [StringLength(60)]
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo Nombre Nacimiento es Requerido")]
        public string? NombreU { get; set; }

       
        [StringLength(60)]
        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El campo Apellido Nacimiento es Requerido")]
        public string? ApellidoU { get; set; }

        [Required(ErrorMessage = "El campo Fecha Nacimiento es Requerido")]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime? FechaNacimientoU { get; set; }

        [Display(Name = "Sueldo")]
        [Required(ErrorMessage = "El campo Sueldo es Requerido")]
        public decimal? SueldoU { get; set; }
        [Display(Name = "Status")]
        [Required(ErrorMessage = "El campo Status es Requerido")]
        public byte? EstatusU { get; set; }
    }
}
