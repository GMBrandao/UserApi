namespace UserApi.Domain.Dto;

public class CreateUserDto
{
    public string? Nome { get; set; }

    public string? Email { get; set; }

    public string? Documento { get; set; }

    public string? Telefone { get; set; }
}