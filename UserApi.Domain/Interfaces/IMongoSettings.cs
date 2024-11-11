namespace UserApi.Domain.Interfaces;

public interface IMongoSettings
{
    string UserCollectionName { get; set; }

    string ConnectionString { get; set; }

    string DatabaseName { get; set; }
}