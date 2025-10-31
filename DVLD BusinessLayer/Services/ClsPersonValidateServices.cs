using DVLD_BusinessLayer.PoepleBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.Services
{
    public class ClsPersonValidateServices
    {
        #region Regex patterns 
        public const string NamePattern = @"^[a-zA-Zا-ي\s-]{3,20}$";
        public const string NationalNoPattern = @"^\d{14}$";
        public const string PhonePattern = @"^\d{11}$";
        public const string EmailPattern = @"^[a-zA-Z0-9._%-]+@(hotmail|yahoo|gmail|outlook|microsoft)(\.[a-zA-Z]{2,})+$";
        public const string AddressPattern = @"^[a-zA-Z0-9ا-ي\s,.\-/]{5,100}$";
        #endregion

        #region Error messages
        public const string NameError = "Invalid input. Please enter 3 to 20 characters (letters only).";
        public const string NationalNoError = "Invalid National No. Please enter exactly 14 digits.";
        public const string PhoneError = "Invalid Phone. Please enter exactly 11 digits.";
        public const string EmailError = "Invalid Email. Please enter a valid email address.";
        public const string AddressError = "Invalid Address. Please enter 5 to 100 characters (letters, numbers, spaces, and ,.-/ allowed).";
        #endregion

        /// <summary>
        /// Validates a given input against a specified regex pattern.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <returns>Returns true if the input matches with pattern, otherwise false</returns>
        public static bool Validate(string input, string pattern)
        {
            try
            {
                return Regex.IsMatch(input?.Trim() ?? string.Empty, pattern);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Validates a specific field value with regex and returns a structured result.
        /// If empty → returns error that field is required.
        /// If invalid → returns error message provided.
        /// If valid → returns success result.
        /// </summary>
        /// <param name="input">The input value to validate</param>
        /// <param name="pattern">Regex pattern to check against</param>
        /// <param name="errorMessage">Error message if validation fails</param>
        /// <param name="fieldName">Field name (for required check)</param>
        /// <returns>ValidationResult containing IsValid + ErrorMessage</returns>
        public static ValidationResult ValidateField(string input, string pattern, string errorMessage, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(input))
                return new ValidationResult(false, $"{fieldName} is required.");

            if (!Validate(input, pattern))
                return new ValidationResult(false, errorMessage);

            return new ValidationResult(true, string.Empty);
        }

        public async static Task<ValidationResult> ValidateNationalNumber(string NationalNo,int PersonID = -1)
        {
            if(ValidateField(NationalNo, NationalNoPattern, NationalNoError, "National Number").IsValid)
            {
                ClsPeopleBusinessLayer peopleBL = new ClsPeopleBusinessLayer();
                ClsPerson CurrentPerson = await peopleBL.GetPersonByNationalNoAsync(NationalNo);
                if (CurrentPerson != null)
                {
                    if (CurrentPerson.PersonID == PersonID)
                        return new ValidationResult(true, string.Empty);
                    else
                        return new ValidationResult(false, "National Number already exists.");
                }
                else
                    return new ValidationResult(true, string.Empty);
            }
            return new ValidationResult(false, "Invalid National Number.");
        }

        /// <summary>
        /// Validates if a given Date of Birth corresponds to a valid age.
        /// Age must be >= 18 and <= 150.
        /// </summary>
        /// <param name="dateOfBirth">The person's date of birth</param>
        /// <param name="errorMessage">Error message if validation fails</param>
        /// <returns>True if valid age, otherwise false</returns>
        public static bool ValidateAge(DateTime dateOfBirth, out string errorMessage)
        {
            errorMessage = string.Empty;
            var age = DateTime.Now.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > DateTime.Now.AddYears(-age))
                age--;

            if (age < 18)
            {
                errorMessage = "Person must be at least 18 years old.";
                return false;
            }

            if (age > 150)
            {
                errorMessage = "Please enter a valid date of birth.";
                return false;
            }

            return true;
        }
    }

    /// <summary>
    /// Represents the result of a validation check.
    /// Contains a boolean (IsValid) and an error message if invalid.
    /// </summary>
    public class ValidationResult
    {
        public bool IsValid { get; }
        public string ErrorMessage { get; }

        public ValidationResult(bool isValid, string errorMessage)
        {
            IsValid = isValid;
            ErrorMessage = errorMessage ?? string.Empty;
        }
    }
}

