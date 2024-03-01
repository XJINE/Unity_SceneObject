using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

[System.Serializable]
public class SceneObject
{
    // CAUTION:
    // It cannot use GUID in runtime app.
    // However, it's important to keep tracking the asset's path.

    [SerializeField] private string path;
    [SerializeField] private string guid;
    public string Path => path;
}

#if UNITY_EDITOR
[CustomPropertyDrawer(typeof(SceneObject))]
public class SceneObjectEditor : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var pathProperty = property.FindPropertyRelative("path");
        var guidProperty = property.FindPropertyRelative("guid");

        var path       = AssetDatabase.GUIDToAssetPath(guidProperty.stringValue);
        var sceneAsset = AssetDatabase.LoadAssetAtPath(path, typeof(SceneAsset)) as SceneAsset;

        var editResult = EditorGUI.ObjectField(position, label, sceneAsset, typeof(SceneAsset), false) as SceneAsset;

        pathProperty.stringValue = editResult == null ? "" : AssetDatabase.GetAssetPath(editResult);
        guidProperty.stringValue = AssetDatabase.AssetPathToGUID(pathProperty.stringValue);
        pathProperty.serializedObject.ApplyModifiedProperties();
    }
}
#endif