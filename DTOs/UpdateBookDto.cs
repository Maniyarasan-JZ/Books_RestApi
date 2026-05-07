using System.ComponentModel.DataAnnotations;

namespace Books_RestApi.DTOs
{
    public class UpdateBookDto
    {
        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = string.Empty;
    }
}