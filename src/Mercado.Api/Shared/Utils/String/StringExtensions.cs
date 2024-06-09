namespace Mercado.Shared.Utils.String;

public static class StringExtensions
{
    public static string ToHash(this string str) => BCrypt.Net.BCrypt.HashPassword(str);
    public static bool VerifyAgainstHashedString(this string providedString, string hashedString) =>
        BCrypt.Net.BCrypt.Verify(providedString, hashedString);
}
