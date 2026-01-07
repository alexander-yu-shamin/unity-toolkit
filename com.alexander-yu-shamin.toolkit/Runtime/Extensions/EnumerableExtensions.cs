using System.Collections.Generic;
using System.Linq;

namespace Toolkit.Runtime.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || !enumerable.Any();
        }

        public static IEnumerable<T> AsIEnumerable<T>(this T item)
        {
            return new[] { item };
        }

        public static List<T> AsList<T>(this T item)
        {
            return new List<T> { item };
        }
    }
}
