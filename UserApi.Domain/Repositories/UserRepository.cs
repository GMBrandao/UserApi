using MongoDB.Driver;
using UserApi.Domain.Entities;
using UserApi.Domain.Interfaces;

namespace UserApi.Domain.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IMongoCollection<User> _repo;

    public UserRepository(IMongoSettings settings)
    {
        var client = new MongoClient(settings.ConnectionString);
        var database = client.GetDatabase(settings.DatabaseName);
        _repo = database.GetCollection<User>(settings.UserCollectionName);
    }

    public void CreateUser(User user) => _repo.InsertOne(user);

    public List<User> GetUsers() => _repo.Find(user => true).ToList();
}