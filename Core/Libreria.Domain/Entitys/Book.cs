using Libreria.Domain.Common;

namespace Libreria.Domain;

public class Book : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Author Author { get; set; } = new Author();
    public Guid AuthorId { get; set; }
    public DateTime PublishDate { get; set; }
    public int Qty { get; set; }
    
}