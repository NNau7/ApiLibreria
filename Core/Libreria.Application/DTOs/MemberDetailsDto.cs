namespace Libreria.Application.DTOs;

public class MemberDetailsDto
{
    public Guid Id { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public int CreationBy { get; set; }
    public DateTime? UpdateDate { get; set; } = DateTime.Now;
    public int? UpdateBy { get; set; }
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
}