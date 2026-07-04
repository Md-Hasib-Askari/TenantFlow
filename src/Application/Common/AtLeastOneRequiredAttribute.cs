using System.ComponentModel.DataAnnotations;

namespace Application.Common;

public class AtLeastOneRequiredAttribute(params string[] propertyNames) : ValidationAttribute
{
    private readonly string[] _propertyNames = propertyNames;

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var properties = validationContext
            .ObjectType.GetProperties()
            .Where(p => _propertyNames.Contains(p.Name));

        foreach (var property in properties)
        {
            var propertyValue = property.GetValue(validationContext.ObjectInstance);
            if (propertyValue != null && !string.IsNullOrWhiteSpace(propertyValue.ToString()))
            {
                return ValidationResult.Success;
            }
        }

        return new ValidationResult(
            $"At least one of the following properties must be provided: {string.Join(", ", _propertyNames)}"
        );
    }
}
