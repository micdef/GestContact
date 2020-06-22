using System;
using System.ComponentModel.DataAnnotations;
using GestContact.Models.Client.Services;

namespace GestContact.Infrastructure.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class EmailExistsAttribute : ValidationAttribute
    {
        public EmailExistsAttribute()
        {
            ErrorMessage = "Email déjà utilisé...";
        }

        public override bool IsValid(object value)
        {
            return ServiceLocator.Instance.AuthService.EmailIsUsed((string)value);
        }
    }
}