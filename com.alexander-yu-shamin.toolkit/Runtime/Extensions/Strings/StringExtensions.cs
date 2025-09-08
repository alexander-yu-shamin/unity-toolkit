namespace Toolkit.Runtime.Extensions.Strings
{
    public static class StringExtensions
    {
        public static string ToSpacedWords(this string text)
        {
          var builder = new StringBuilder();

          foreach (var c in text)
          {
            if (char.IsUpper(c) && builder.Length > 0)
            {
              builder.Append(' ');
            }

            builder.Append(c);
          }

          return builder.ToString();
        }
    }
}