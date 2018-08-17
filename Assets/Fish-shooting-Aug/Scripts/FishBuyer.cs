using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// trung ca
public class FishBuyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void BuyFish(Player player, Fish fish)
    {
        var payment = fish.Value;
        //var amountGot
        player.GetAmount(payment);
    }
}
