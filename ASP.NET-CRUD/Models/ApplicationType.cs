using System.ComponentModel.DataAnnotations;

namespace ASP.NET_CRUD.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
