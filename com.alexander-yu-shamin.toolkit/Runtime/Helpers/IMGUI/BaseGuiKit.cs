using System;
using UnityEngine;

namespace Toolkit.Runtime.Helpers.IMGUI
{
    public class BaseGuiKit
    {
        public static void InnerChangeValue<T>(Func<T> getter, Action<T> setter, T newValue, Action innerAction)
        {
            if (getter == null || setter == null || innerAction == null)
            {
                return;
            }

            var oldValue = getter();
            setter(newValue);
            innerAction();
            setter(oldValue);
        }

        public static void Color(Color color, Action action)
        {
            InnerChangeValue(() => GUI.color, value => GUI.color = value, color, action);
        }

        public static void BackgroundColor(Color color, Action action)
        {
            InnerChangeValue(() => GUI.backgroundColor, value => GUI.backgroundColor = value, color, action);
        }

        public static void Enable(bool isEnabled, Action action)
        {
            InnerChangeValue(() => GUI.enabled, value => GUI.enabled = value, isEnabled, action);
        }

        public static void Button(bool isEnabled, string text, Action action, GUIStyle style,
            params GUILayoutOption[] options)
        {
            Enable(isEnabled, () => { Button(text, action, style, options); });
        }

        public static void Button(string text, Action action, GUIStyle style, params GUILayoutOption[] options)
        {
            if (GUILayout.Button(text, style, options))
            {
                action?.Invoke();
            }
        }

        public static void Button(GUIContent content, Action action, GUIStyle style, params GUILayoutOption[] options)
        {
            if (GUILayout.Button(content, style, options))
            {
                action?.Invoke();
            }
        }

        public static void Button(string text, Action action, params GUILayoutOption[] options)
        {
            Button(text, action, GUI.skin.button, options);
        }

        public static void Button(GUIContent content, Action action, params GUILayoutOption[] options)
        {
            Button(content, action, GUI.skin.button, options);
        }

        public static void Button(bool isEnabled, string text, Action action, params GUILayoutOption[] options)
        {
            Button(isEnabled, text, action, GUI.skin.button, options);
        }

        public static void FlexibleSpace()
        {
            GUILayout.FlexibleSpace();
        }

        public static void Label(string text, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.Label(text, style, options);
        }

        public static void Label(string text, params GUILayoutOption[] options)
        {
            Label(text, GUI.skin.label);
        }
    }
}