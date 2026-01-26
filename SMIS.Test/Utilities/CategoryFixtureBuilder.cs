using AutoFixture;
using SMIS.Application.DTO.Categories;

namespace SMIS.Test.Utilities;

public class CategoryFixtureBuilder
{
    private readonly IFixture _fixture;
    private string? _name;
    private string? _code;
    private string? _description;
    private bool? _isActive;
    private bool _nameSet;
    private bool _codeSet;
    private bool _descriptionSet;

    public CategoryFixtureBuilder( )
    {
        _fixture = new Fixture();
    }

    public CategoryFixtureBuilder WithName(string name)
    {
        _name = name;
        _nameSet = true;
        return this;
    }

    public CategoryFixtureBuilder WithCode(string? code)
    {
        _code = code;
        _codeSet = true;
        return this;
    }

    public CategoryFixtureBuilder WithDescription(string? description)
    {
        _description = description;
        _descriptionSet = true;
        return this;
    }

    public CategoryFixtureBuilder WithIsActive(bool isActive)
    {
        _isActive = isActive;
        return this;
    }

    public CategoryCreateDto Build( ) => new()
    {
        Name = _nameSet ? _name! : GenerateUniqueName(),
        Code = _codeSet ? _code : GenerateUniqueCode(),
        Description = _descriptionSet ? _description : GenerateUniqueDescription(),
        IsActive = _isActive ?? true
    };

    private static string GenerateUniqueName( ) => $"Name{Guid.NewGuid()}";
    private static string GenerateUniqueCode( ) => $"CODE{Guid.NewGuid()}";
    private static string GenerateUniqueDescription( ) => $"Description{Guid.NewGuid()}";
}