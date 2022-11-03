using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteData : MonoBehaviour
{
    public Data data;

    public void DeleteButon()
    {
        for (int i = 0; i < data.levelsCompleted.Count; i++)
        {
            data.levelsCompleted[i] = false;
        }
    }
}
