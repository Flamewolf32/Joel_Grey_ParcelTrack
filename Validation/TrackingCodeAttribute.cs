using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ParcelTrack.Validation
{
    public class TrackingCodeAttribute : ValidationAttribute
    {
        private const string Pattern = "^PT-[0-9]{6}$";

        public TrackingCodeAttribute()
        {
            ErrorMessage = "Tracking code must look like PT-123456";
        }

        public override bool IsValid(object? value)
        {
            string? code = value as string;
            if (string.IsNullOrEmpty(code))
            {
                return true;
            }
            return Regex.IsMatch(code, Pattern);
        }
    }
}
