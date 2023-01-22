using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Filters;

public class NameValidation : ValidationAttribute
{
    private int NameLength { get; }

    public NameValidation(int nameLength)
    {
        NameLength = nameLength;
    }

    private  string GetErrorMessage() =>
        "Minimum of 4 characters!";

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        return value.ToString()!.Length < NameLength ? new ValidationResult(GetErrorMessage()) : ValidationResult.Success;
    }
}