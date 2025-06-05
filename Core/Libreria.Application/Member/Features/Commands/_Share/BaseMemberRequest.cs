namespace Libreria.Application.Member.Features.Commands._Share;

public class BaseMemberRequest
{
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
}