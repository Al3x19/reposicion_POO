using System.ComponentModel.DataAnnotations;

namespace ReposicionPOO.DataBase.Entidades
{

    public class CategoryEntity
    {
        public Guid Id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "el {0} es requerido")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [MinLength(10, ErrorMessage = "la {0} debe tener almenos {1} caracter")]
        public string Description { get; set; }
    }
}
