﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFishGroup : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float y = transform.position.y;

        if (x > 35 || x < -35 || y > 25 || y < -25)
        {
            Destroy(this.gameObject);
            FishManager.allFishGroupCounter--;
        }

    }
}
