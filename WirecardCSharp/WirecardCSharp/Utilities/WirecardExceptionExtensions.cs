using System.Linq;
using System.Text;
using WirecardCSharp.Exception;

namespace WirecardCSharp
{
    public static class WirecardExceptionExtensions
    {
        public static string GetExceptionText(this WirecardException we)
        {
            var sb = new StringBuilder();

            if (we != null)
            {
                if (we.wirecardError == null || !we.wirecardError.errors.Any())
                    return sb.ToString();

                foreach (var error in we.wirecardError.errors)
                    sb.AppendLine($"{error.description} ({error.code})");
            }
            return sb.ToString();
        }
    }
}