using FluentAssertions;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Categories;
using SMIS.UI.Shared.Helpers;
using Xunit;

namespace SMIS.UI.Test.Services;

public class ValidationHelperTests
{
    [Fact]
    public void ExtractValidationErrors_WhenResultHasPropertyErrors_ReturnsDictionary()
    {
        // Arrange
        var result = Result<CategoryDto>.WithErrors(new List<ValidationError>
        {
            new() { Property = "name", Description = "Name is required" },
            new() { Property = "code", Description = "Code is too long" }
        });

        // Act
        var errors = ValidationHelper.ExtractValidationErrors(result);

        // Assert
        errors.Should().ContainKey("Name").WhoseValue.Should().Be("Name is required");
        errors.Should().ContainKey("Code").WhoseValue.Should().Be("Code is too long");
    }

    [Fact]
    public void ExtractValidationErrors_WhenErrorHasNoProperty_IsSkipped()
    {
        // Arrange — errors without a Property are general errors, not field-level
        var result = Result<CategoryDto>.FailureResult("General failure");

        // Act
        var errors = ValidationHelper.ExtractValidationErrors(result);

        // Assert
        errors.Should().BeEmpty();
    }

    [Fact]
    public void ExtractValidationErrors_WhenResultHasNoErrors_ReturnsEmptyDictionary()
    {
        var result = Result<CategoryDto>.SuccessResult(new CategoryDto());

        var errors = ValidationHelper.ExtractValidationErrors(result);

        errors.Should().BeEmpty();
    }

    [Fact]
    public void GetValidationMessage_WhenKeyExists_ReturnsMessage()
    {
        var errors = new Dictionary<string, string> { { "Name", "Required" } };

        ValidationHelper.GetValidationMessage(errors, "Name").Should().Be("Required");
    }

    [Fact]
    public void GetValidationMessage_WhenKeyMissing_ReturnsEmptyString()
    {
        var errors = new Dictionary<string, string>();

        ValidationHelper.GetValidationMessage(errors, "Name").Should().BeEmpty();
    }

    [Fact]
    public void HasValidationError_WhenKeyExists_ReturnsTrue()
    {
        var errors = new Dictionary<string, string> { { "Name", "Required" } };

        ValidationHelper.HasValidationError(errors, "Name").Should().BeTrue();
    }
}
