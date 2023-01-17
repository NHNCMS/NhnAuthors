using Microsoft.Extensions.DependencyInjection;
using NhnAuthors.Module.Authors.Abstracts;
using NhnAuthors.Module.Authors.Concretes;

namespace NhnAuthors.Module.Authors;

public static class AuthorsHelper
{
    public static IServiceCollection AddAuthorServices(this IServiceCollection services)
    {
        services.AddScoped<IAuthorService, AuthorService>();

        return services;
    }
}