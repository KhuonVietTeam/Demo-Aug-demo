using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionPlayers : MonoBehaviour {
    public static Player player1,player2,player3,player4;
    //Bullet bullet;
    //Fish fish;
    //BulletSeller bulletSeller; //ban dan
    //FishBuyer fishBuyer; //trung ca
    //CoinBuyer coinBuyert; //nap Coin
    //CoinSeller coinSeller; //xã coin

                            // Use this for initialization
    void Start () {
        player1 = new Player("player1", 100, 1);
        player2 = new Player("player2", 100, 1);
        player3 = new Player("player3", 100, 1);
        player4 = new Player("player4", 100, 1);
        Debug.Log(player1._wallet._value);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
