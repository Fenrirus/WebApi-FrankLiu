using System.ComponentModel.DataAnnotations;
using WebApiFrankLiu.Models;

namespace WebApiFrankLiu.Validation
{
    public class ReleaseDateInPast : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var product = (Product)validationContext.ObjectInstance;

            if (product.ReleaseDate > System.DateTime.Today)
            {
                return new ValidationResult("The product release date has to be in the past");
            }
            return ValidationResult.Success;
        }
    }
}