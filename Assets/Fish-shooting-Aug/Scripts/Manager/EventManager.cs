using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static BulletSeller bulletseller;
    public static CoinBuyer coinbuyer;
    public static CoinSeller coinseller;
    public static FishBuyer fishbuyer;
    // Use this for initialization
    private void Awake()
    {
        bulletseller = new BulletSeller();
        coinbuyer = new CoinBuyer();
        coinseller = new CoinSeller();
        fishbuyer = new FishBuyer();
    }
}
