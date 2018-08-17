
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// nap the
public class CoinBuyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BuyCoin(Player player)
    {
        //mệnh giá coin mặc định là 5
        var payment = 5;
        //var amountGot
        player.GetAmount(payment);
    }
}
