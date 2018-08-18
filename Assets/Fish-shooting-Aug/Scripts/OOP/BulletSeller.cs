using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSeller  {
    
	
    public void SellBullet(Player player) //xem lai
    {

        var payment = player.WatchBullet(); //xem lai //xem tien

        var amountPaid = player.PayAmount(payment);

        if (amountPaid != payment)
        {
            // het tien
            // Khong ban duoc dan tuong ung
        }
    }
}
