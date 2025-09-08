using UnityEngine;

namespace Toolkit.Runtime.Extensions
{
    public static class TransformExtensions
    {
        public static void SetLayerRecursively(this Transform transform, LayerMask layer)
        {
            if (transform == null)
            {
                return;
            }

            if (transform.gameObject == null)
            {
                return;
            }

            transform.gameObject.layer = layer;

            foreach (Transform child in transform)
            {
                child.SetLayerRecursively(layer);
            }
        }
    }
}
