using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MyTextBooksMain.Models
{
    public class Books
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Book Name" )]
        public string BookName { get; set; }

       [Display(Name = "Books description")]
       
        public string BookDescription { get; set; }

        [Display(Name = "How many Books with the same Name")]
        [Range(1,99)]
        [Required]
        public int BookQuantity { get; set; }
        [Display(Name = "Book Price" )]
        [Range(0,100000000)]
        [Required]
        public double BookPrice { get; set; }
        [Display(Name = "Book Quality ")]
        [Required]
        public string Ratings { get; set; }
       
                
    }
}
