using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace DefaultNamespace
{
    public class ReadOnlyAttribute : PropertyAttribute
    { }


#if UNITY_EDITOR

    [CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
    public class ReadOnlyPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // Отключаем редактирование
            GUI.enabled = false;

            // Рисуем поле как обычно, с возможностью изменять только отображение
            EditorGUI.PropertyField(position, property, label);

            // Включаем обратно редактирование
            GUI.enabled = true;
        }

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var element = base.CreatePropertyGUI(property)
            ?? new UnityEditor.UIElements.PropertyField(property);

            element.SetEnabled(false);
            return element;
        }
    }
#endif
}
