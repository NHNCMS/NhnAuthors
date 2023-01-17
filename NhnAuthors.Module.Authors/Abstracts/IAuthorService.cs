using NhnAuthors.Module.Authors.Extensions.Dtos;

namespace NhnAuthors.Module.Authors.Abstracts;

public interface IAuthorService
{
    Task<AuthorDto> GetAuthor(string authorId);

    Task<string> CreateAuthor(AuthorWithoutIdDto newAuthorWithoutId);

    Task<string> ReplaceAuthor(string authorId, AuthorWithoutIdDto newAuthorWithoutId);

    Task<string> UpdateAuthor(string authorId, AuthorPatchDto patchDto);

    Task<string> DeleteAuthor(string authorId);
}