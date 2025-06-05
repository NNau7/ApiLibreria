namespace Libreria.Domain.Common;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public int CreationBy { get; set; }
    public DateTime? UpdateDate { get; set; } = DateTime.Now;
    public int? UpdateBy { get; set; }
}