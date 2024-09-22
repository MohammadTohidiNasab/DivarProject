using System.ComponentModel.DataAnnotations;

namespace DivarProject.Models
{
    public class Advertisement
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsAvailable { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }// Foreign key to User
        public User User { get; set; }
    }
}
