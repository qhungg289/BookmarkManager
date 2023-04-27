using Microsoft.AspNetCore.Identity;

namespace BookmarkManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();
        public List<Folder> Folders { get; set; } = new List<Folder>();
    }
}
