﻿namespace NhnAuthors.Module.Authors.Extensions.Dtos;

public record AuthorWithoutIdDto
{
    public string Name { get; init; } = string.Empty;

    public string Mail { get; init; } = string.Empty;

    public string Bio { get; init; } = string.Empty;
}