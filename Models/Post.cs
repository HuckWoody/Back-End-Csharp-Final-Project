using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinalLesson.Models
{
    public class Post {
        public int PostID { get; set; }
        [Required]
        [DisplayName("Title")]
        public string title { get; set; }
        [Required]
        [DisplayName("Content")]
        public string content { get; set; }
        [Required]
        [DisplayName("Date")]
        public DateTime timestamp { get; set; }
        // [Required]
        public AppUser User { get; set;}
    }
}