using System;
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

        public static void Toggle(string text, bool value, Action<bool> action)
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

        public static void ScrollView(ref Vector2 scrollPosition, Action content, params GUILayoutOption[] options)
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

            scrollPosition = result;
        }

        public static bool FoldoutHeaderGroup(bool foldout, string content, Action action, GUIStyle style = null,
            Action<Rect> menuAction = null, GUIStyle menuIcon = null)
        {
            var result = EditorGUILayout.BeginFoldoutHeaderGroup(foldout, content, style, menuAction, menuIcon);
            action?.Invoke();
            EditorGUILayout.EndFoldoutHeaderGroup();
            return result;
        }

        public static void Space()
        {
            EditorGUILayout.Space();
        }

        public static void Space(float width)
        {
            EditorGUILayout.Space(width);
        }

        public static void Space(float width, bool expand)
        {
            EditorGUILayout.Space(width, expand);
        }
    }
}
