namespace Libreria.Application.Exceptions;
[Serializable]
public class BadRequestException : Exception
{
    public BadRequestException(string? message, IDictionary<string, string[]> errors) : base(message)
    {
        Errors = errors;
    }
    
    public IDictionary<string, string[]> Errors { get; }
}