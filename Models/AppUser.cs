using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace FinalLesson.Models {
    public class AppUser : IdentityUser {
        public IEnumerable<Post> Posts { get; set;}
    }
}