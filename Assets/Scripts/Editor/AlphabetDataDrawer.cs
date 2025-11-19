using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

[CustomEditor(typeof(AlphabetData))]
public class AlphabetDataDrawer : Editor
{
    private ReorderableList plainList;
    private ReorderableList normalList;
    private ReorderableList highlightedList;
    private ReorderableList wrongList;

    // SÓ TEM UM OnEnable() – esse é o correto!
    private void OnEnable()
    {
        plainList       = CreateList("AlphabetPlain",       "Alphabet Plain");
        normalList      = CreateList("AlphabetNormal",      "Alphabet Normal");
        highlightedList = CreateList("AlphabetHighlighted", "Alphabet Highlighted");
        wrongList       = CreateList("AlphabetWrong",       "Alphabet Wrong");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        // Atualiza as referências (importante!)
        plainList.serializedProperty       = serializedObject.FindProperty("AlphabetPlain");
        normalList.serializedProperty      = serializedObject.FindProperty("AlphabetNormal");
        highlightedList.serializedProperty = serializedObject.FindProperty("AlphabetHighlighted");
        wrongList.serializedProperty       = serializedObject.FindProperty("AlphabetWrong");

        plainList.DoLayoutList();
        normalList.DoLayoutList();
        highlightedList.DoLayoutList();
        wrongList.DoLayoutList();

        EditorGUILayout.Space(20);
        if (GUILayout.Button("Populate All Lists (A-Z)", GUILayout.Height(40)))
            PopulateAllLists();

        serializedObject.ApplyModifiedProperties();
    }

    private ReorderableList CreateList(string propertyName, string label)
    {
        var prop = serializedObject.FindProperty(propertyName);
        var list = new ReorderableList(serializedObject, prop, true, true, true, true);

        list.drawHeaderCallback = rect => EditorGUI.LabelField(rect, label);

        list.drawElementCallback = (rect, index, isActive, isFocused) =>
        {
            var element = list.serializedProperty.GetArrayElementAtIndex(index);
            rect.y += 2;
            float h = EditorGUIUtility.singleLineHeight;

            EditorGUI.PropertyField(new Rect(rect.x,      rect.y, 50,     h),
                element.FindPropertyRelative("letter"), GUIContent.none);

            EditorGUI.PropertyField(new Rect(rect.x + 60, rect.y, rect.width - 60, h),
                element.FindPropertyRelative("image"), GUIContent.none);
        };

        list.elementHeight = EditorGUIUtility.singleLineHeight + 6;
        return list;
    }

    private void PopulateAllLists()
    {
        var data = (AlphabetData)target;
        
        void Fill(System.Collections.Generic.List<AlphabetData.LetterData> lst)
        {
            lst.Clear();
            for (char c = 'A'; c <= 'Z'; c++)
                lst.Add(new AlphabetData.LetterData { letter = c.ToString(), image = null });
        }

        Fill(data.AlphabetPlain);
        Fill(data.AlphabetNormal);
        Fill(data.AlphabetHighlighted);
        Fill(data.AlphabetWrong);

        EditorUtility.SetDirty(data);
        Debug.Log("Alfabeto preenchido com sucesso!");
    }
}