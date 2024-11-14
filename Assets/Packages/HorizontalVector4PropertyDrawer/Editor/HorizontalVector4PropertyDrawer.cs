using UnityEngine;

namespace UnityEditor
{
    // NOTE:
    // This code is based on the following article:
    // https://unixo-lab.com/unity/vector4drawer.html

    [CustomPropertyDrawer(typeof(Vector4))]
    public class HorizontalVector4PropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            label = EditorGUI.BeginProperty(position, label, property);

            EditorGUI.BeginChangeCheck();

            var newValue = EditorGUI.Vector4Field(position, label, property.vector4Value);

            if (EditorGUI.EndChangeCheck())
            {
                property.vector4Value = newValue;
            }

            EditorGUI.EndProperty();
        }
    }
}