﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnScore : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Bird>() != null)
            GameControl.ins.BirdScore();

    }
}
