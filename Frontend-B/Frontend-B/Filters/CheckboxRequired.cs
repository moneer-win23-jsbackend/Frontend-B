using System.ComponentModel.DataAnnotations;

namespace Frontend_B.Filters
{
    public class CheckboxRequired : ValidationAttribute
    {
        public override bool IsValid(object? value) => value is bool b && b;
    }
}
