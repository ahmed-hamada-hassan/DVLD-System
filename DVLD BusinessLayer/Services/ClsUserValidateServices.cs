using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.Services
{
    public class ClsUserValidateServices
    {
        #region Regex Patterns
        public const string UserNamePattern = @"^[a-zA-Z0-9](?:[._]?[a-zA-z0-9]){4,19}$";
        public const string PasswordPattern = @"^[a-zA-Z0-9!@#$%^&*()_+\-=\[\]{};':"",.<>/?\\|]{4,20}$";
        #endregion

        #region ErrorMessage
        public const string UserNameError = "Invalid User Name , Please enter 5 to 20 characters";
        public const string PasswordError = "Invalid Password. Please enter 4 to 20 digits.";
        #endregion

        public static bool Validate (string input , string pattern)
        {
            try
            {
                return Regex.IsMatch(input?.Trim()??string.Empty, pattern);
            }
            catch
            {
                return false;
            }
        }

        public static ValidateResult ValidateField(string input , string pattern,string errorMessage,string fieldName)
        {
            if (string.IsNullOrEmpty(input))
                return new ValidateResult(false, $"{fieldName} is required");

            if (!Validate(input, pattern))
                return new ValidateResult(false, errorMessage);

            return new ValidateResult(true,string.Empty);
        }
    }

    public class ValidateResult
    {
        public bool isValid { get; }
        public string errorMessage { get; }

        public ValidateResult(bool isValid, string errorMessage)
        {
            this.isValid = isValid;
            this.errorMessage = errorMessage;
        }
    }

}
