using UserApi.Domain.Dto;
using UserApi.Domain.Entities;

namespace UserApi.Domain.Interfaces;

public interface IUserService
{
    List<User> GetUsers();

    void CreateUser(CreateUserDto userDto);
}