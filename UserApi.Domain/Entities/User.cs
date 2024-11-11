namespace UserApi.Domain.Entities;

public class User
{
    public Guid Id { get; set; }

    public string? Nome {get;set;}

    public string? Email {get;set;}

    public string? Documento { get; set; }

    public string? Telefone { get; set; }
}