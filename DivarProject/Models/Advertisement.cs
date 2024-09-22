using System.ComponentModel.DataAnnotations;

namespace DivarProject.Models
{
    public class Advertisement
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
