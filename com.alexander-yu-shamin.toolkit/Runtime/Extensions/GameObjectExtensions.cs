using UnityEngine;

namespace Toolkit.Runtime.Extensions
{
    public static class GameObjectExtensions
    {
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            if (gameObject == null)
            {
                return null;
            }

            return gameObject.GetComponent<T>() ?? gameObject.AddComponent<T>();
        }
    }
}
