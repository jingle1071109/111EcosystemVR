﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject[] objects;

    private bool enableda;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) enableda = !enableda;

        foreach(GameObject g in objects)
        {
            g.SetActive(enableda);
        }
    }
}
