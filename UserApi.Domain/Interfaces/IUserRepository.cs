using UserApi.Domain.Entities;

namespace UserApi.Domain.Interfaces;

public interface IUserRepository
{
    List<User> GetUsers();

    void CreateUser(User user);
}