using UserApi.Domain.Dto;
using UserApi.Domain.Entities;
using UserApi.Domain.Interfaces;

namespace UserApi.Domain.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public void CreateUser(CreateUserDto userDto)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            Nome = userDto.Nome!,
            Email = userDto.Email,
            Documento = userDto.Documento,
            Telefone = userDto.Telefone
        };

        _userRepository.CreateUser(user);
    }

    public List<User> GetUsers()
    {
        return _userRepository.GetUsers();
    }
}