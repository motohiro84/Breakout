﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectBreaker : MonoBehaviour
{
    void Start()
    {
        Invoke("BreakEffect",2.0f);
    }
 
    void BreakEffect()
    {
        Destroy(gameObject);
    }
}