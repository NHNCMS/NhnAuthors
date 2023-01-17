using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NhnAuthors.DataModel.Abstracts;
using NhnAuthors.DataModel.Models;
using NhnAuthors.DataModel.MongoDb.Persisters;
using NhnAuthors.Shared.Configuration;

namespace NhnAuthors.DataModel.MongoDb;

public static class MongoDbHelper
{
    public static IServiceCollection AddMongoDbPersister(this IServiceCollection services)
    {
        services.AddSingleton(serviceProvider =>
        {
            var mongoDbParameter = serviceProvider
                .GetRequiredService<IOptions<AppSettings>>()
                .Value.MongoDbParameters;

            var client = new MongoClient(mongoDbParameter.ConnectionString);
            var database = client.GetDatabase(mongoDbParameter.DatabaseName);
            return database;
        });

        services.AddScoped<IPersister<AuthorModel>, Persister<AuthorModel>>();

        return services;
    }
}