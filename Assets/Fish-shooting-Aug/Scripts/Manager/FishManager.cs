﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour {
    public static int allFishCounter;
    public static int allFishGroupCounter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
    {
        Debug.Log(allFishCounter + allFishGroupCounter);
    }
}
