namespace Lotto.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Banca
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(60, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Required] public string Name { get; set; }

        [Display(Name = "Dueño")]
        public int Propietario { get; set; }

        [Display(Name = "Last Purchase")]
        public int Localidad { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool IsAvailabe { get; set; }
    }
}
