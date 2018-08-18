
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// nap the
public class CoinBuyer  {


    public void BuyCoin(Player player)
    {
        //mệnh giá coin mặc định là 5
        var payment = 5;
        //var amountGot
        player.GetAmount(payment);
    }
}
