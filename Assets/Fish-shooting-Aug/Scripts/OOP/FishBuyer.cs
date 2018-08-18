using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// trung ca
public class FishBuyer  {



    public void BuyFish(Player player, Fish fish)
    {
        var payment = fish.Value;
        //var amountGot
        player.GetAmount(payment);
    }
}
