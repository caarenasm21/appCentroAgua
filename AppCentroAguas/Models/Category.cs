using System.Collections.Generic;

namespace AppCentroAguas.Models
{
    public class Category
    {
        public string? Name { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
