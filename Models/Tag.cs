using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookmarkManager.Models
{
    public class Tag
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string Name { get; set; } = string.Empty;
        public List<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();
    }
}
