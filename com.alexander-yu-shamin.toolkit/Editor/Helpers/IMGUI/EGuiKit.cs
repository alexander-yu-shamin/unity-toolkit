using System;
using UnityEditor;
using UnityEngine;
using Toolkit.Runtime.Helpers.IMGUI;
using EditorGUILayout = UnityEditor.EditorGUILayout;

namespace Toolkit.Editor.Helpers.IMGUI
{
    public class EGuiKit : BaseGuiKit
    {
        public static void Horizontal(Action action)
        {
            Horizontal(action, GUIStyle.none);
        }

        public static void Horizontal(Action action, GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginHorizontal(style, options);
            action?.Invoke();
            EditorGUILayout.EndHorizontal();
        }

        public static void Vertical(Action action)
        {
            Vertical(action, GUIStyle.none);
        }

        public static void Vertical(Action action, GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginVertical(style, options);
            action?.Invoke();
            EditorGUILayout.EndVertical();
        }

        public static void Toogle(string text, bool value, Action<bool> action)
        {
            var result = EditorGUILayout.Toggle(value, text);
            action?.Invoke(result);
        }

        public static Vector2 ScrollView(Vector2 scrollPosition, Action content, params GUILayoutOption[] options)
        {
            var result = EditorGUILayout.BeginScrollView(scrollPosition, options);
            try
            {
                content?.Invoke();
            }
            finally
            {
                EditorGUILayout.EndScrollView();
            }

            return result;
        }
    }
}
