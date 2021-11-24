using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArshBooks.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1,10000)]
        public string ListPrice { get; set; }
        public string ImageUrl { get; set; }

        [Required]
        public string CategoryId { get; set; }      // Foreign key reference
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Required]
        public string CoverTypeId { get; set; }     // Foreign key reference
        [ForeignKey("CategoryId")]
        public Category CoverType { get; set; }



    }
}
