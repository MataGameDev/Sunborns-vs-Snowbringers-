using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCom : MonoBehaviour
{
    public GameObject[] levels;
    public Data data;

    private void Start()
    {
        for (int i = 0; i < data.levelsCompleted.Count; i++)
        {
            levels[i].SetActive(data.levelsCompleted[i]);
        }
    }
}
