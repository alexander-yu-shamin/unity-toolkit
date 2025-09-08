using UnityEngine;

namespace Toolkit.Runtime.Extensions.Unity
{
    public static class UnityObjectExtensions
    {
        public static void Safe<T>(this T obj, System.Action<T> action) where T : class
        {
            if (obj != null)
            {
                action?.Invoke(obj);
            }
        }

        public static void Safe<T>(this T obj, System.Action<T> action, System.Action fallback) where T : class
        {
            if (obj != null)
            {
                action?.Invoke(obj);
            }
            else
            {
                fallback?.Invoke();
            }
        }
    }
}