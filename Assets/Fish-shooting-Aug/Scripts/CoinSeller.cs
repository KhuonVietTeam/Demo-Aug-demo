﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Xã thẻ

public class CoinSeller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SellCoin(Player player)
    {
        var payment = 5;  // 1 xu menh gia la 5
        var amountPaid = player.PayAmount(payment);
        if (amountPaid != payment)
        {
            // het tien
            // Khong xa duoc the
        }

    }
    public void SellAllCoins(Player player)
    {
        var payment = player.WatchWallet() ;
        var amountPaid = player.PayAmount(payment);
        if (amountPaid != payment)
        {
            // het tien
            // Khong xa duoc the
        }

    }
}
