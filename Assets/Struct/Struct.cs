using System.Collections.Generic;
using UnityEngine;

// Class => Heap
public class Struct : MonoBehaviour
{
    public CharacterInfo characterInfo;
    private void Start()
    {
        characterInfo.name = "Atiba";
        characterInfo.age = "39";

        Debug.Log(characterInfo.name + " " + characterInfo.age);
    }
}

// Struct => Stack
[System.Serializable]
public struct CharacterInfo
{
    public string name;
    public string age;
}
