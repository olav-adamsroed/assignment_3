using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace assignment_3.Models
{
    public class Guestbook
    {
        public int Id { get; set; }
        
        [StringLength(100)]
        [DisplayName("Name")]
        public string WholeName { get; set; }
        
        [Required]
        [MinLength(5), MaxLength(50)]
        [DisplayName("Title")]
        public string Title { get; set; }
        
        [Required]
        [MinLength(20), MaxLength(200)]
        [DisplayName("Message")]
        public string Message { get; set; }
    }
}