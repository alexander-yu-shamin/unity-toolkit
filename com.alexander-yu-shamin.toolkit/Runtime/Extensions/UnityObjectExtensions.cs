namespace Toolkit.Runtime.Extensions
{
    public static class UnityObjectExtensions
    {
        public static void Safe<T>(this T obj, System.Action<T> action) where T : UnityEngine.Object
        {
            if (obj != null)
            {
                action?.Invoke(obj);
            }
        }

        public static void Safe<T>(this T obj, System.Action<T> action, System.Action fallback) where T : UnityEngine.Object
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