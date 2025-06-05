namespace Libreria.Application.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException(string name, string key ) : base( $"El {name} con id {key} no fue encontrado.")
    {
        
    }
}