﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myInstantiation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myPrefab;
    void Start()
    {
        Instantiate(myPrefab, new Vector2(0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
