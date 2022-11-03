using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new data", menuName = "data")]
public class Data : ScriptableObject
{
    public List<bool> levelsCompleted;
}
