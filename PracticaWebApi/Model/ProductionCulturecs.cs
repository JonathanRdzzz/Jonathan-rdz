using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace PracticaWebApi.Model
{
    public class ProductionCulturecs
    {
        
    
        [Table("Culture", Schema = "Production")]
        public class Culture
        {
            [Key]
            [Column(TypeName = "nchar(6)")]
            public string CultureID { get; set; }

            [Required]
            [Column(TypeName = "nvarchar(50)")]
            public string Name { get; set; }

            [Required]
            public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;
        }

        
    }
}

