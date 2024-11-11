using UserApi.Domain.Interfaces;

namespace UserApi.Settings;

public sealed class MongoSettings : IMongoSettings
{
    public string UserCollectionName { get; set; }

    public string ConnectionString { get; set; }

    public string DatabaseName { get; set; }
}