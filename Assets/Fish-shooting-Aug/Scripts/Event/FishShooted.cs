﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishShooted : MonoBehaviour {
    public int bloodFish = 1;
    private GameObject srcCoin,coin;
    private Transform CoinZone;

    void Awake()
    {
        srcCoin = Resources.Load<GameObject>("Coin/coinAni");


    }
    // Use this for initialization
    void Start () {

        CoinZone = transform.Find("/CoinZone");

    }

    // Update is called once per frame
    void Update () {
		if(bloodFish == 0)
        {
            Destroy(this.gameObject);  //destroy this fish
            coin = Instantiate(srcCoin, transform.position, transform.rotation) as GameObject;
            coin.name = "coin";
            coin.transform.SetParent(CoinZone, true);


        }
    }

    //Fishes catched by Web
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Web"))
        {
            if(Random.Range(0,2) < 1)
            {
                bloodFish--;

            }

        }
    }
}
