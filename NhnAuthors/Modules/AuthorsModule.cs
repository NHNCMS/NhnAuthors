﻿using NhnAuthors.Module.Authors;
using NhnAuthors.Module.Authors.Endpoints;
using NhnAuthors.Module.Authors.Extensions.Dtos;
using NhnAuthors.Module.Shared.Extensions.Dtos;

namespace NhnAuthors.Modules;

public class AuthorsModule : IModule
{
    public bool IsEnabled => true;
    public int Order => 0;

    public IServiceCollection RegisterModule(WebApplicationBuilder builder)
    {
        builder.Services.AddAuthorServices();

        return builder.Services;
    }

    public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
    {
        var endpointGroup = endpoints.MapGroup("v1/authors").WithTags("Authors");

        endpointGroup.MapGet("{id}", AuthorsEndpoints.HandleGetAuthor)
            .Produces(StatusCodes.Status200OK, typeof(AuthorDto))
            .Produces(StatusCodes.Status404NotFound)
            .WithName("GetAuthor");

        endpointGroup.MapPost(string.Empty, AuthorsEndpoints.HandleCreateAuthor)
            .Produces(StatusCodes.Status201Created, typeof(IdDto))
            .WithName("CreateAuthor");

        endpointGroup.MapPut("{id}", AuthorsEndpoints.HandleReplaceAuthor)
            .Produces(StatusCodes.Status200OK, typeof(IdDto))
            .Produces(StatusCodes.Status404NotFound)
            .WithName("ReplaceAuthor");

        endpointGroup.MapPatch("{id}", AuthorsEndpoints.HandlePatchAuthor)
            .Produces(StatusCodes.Status200OK, typeof(IdDto))
            .Produces(StatusCodes.Status404NotFound)
            .WithName("UpdateAuthor");

        endpointGroup.MapDelete("{id}", AuthorsEndpoints.HandleDeleteAuthor)
            .Produces(StatusCodes.Status202Accepted)
            .Produces(StatusCodes.Status404NotFound)
            .WithName("DeleteAuthor");

        return endpoints;
    }
}