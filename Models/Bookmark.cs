using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookmarkManager.Models
{
    public class Bookmark
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string Url { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int? FolderId { get; set; }
        public Folder? Folder { get; set; } = null!;
        public string UserId { get; set; } = string.Empty;

        public ApplicationUser User { get; set; } = null!;

        public List<Tag> Tags { get; set; } = new List<Tag>();
    }
}
