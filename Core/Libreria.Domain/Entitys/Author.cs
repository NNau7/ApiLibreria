using Libreria.Domain.Common;

namespace Libreria.Domain;

public class Author : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    
}