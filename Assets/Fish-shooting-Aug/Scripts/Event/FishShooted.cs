using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishShooted : MonoBehaviour {
    public int bloodFish = 1;
    public Player beKilledBy;
    public int benefitValue;
    private GameObject srcCoin,coin;
    private Transform CoinZone;
    public static int pointvalue;
    Fish fish;
    void Awake()
    {
        benefitValue = bloodFish;  // Default: Gia tri fish = Máu cá
        srcCoin = Resources.Load<GameObject>("Coin/coinAni");
        fish = new Fish(this.gameObject.name,benefitValue);

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
            EventManager.fishbuyer.BuyFish(beKilledBy, fish);
            FishManager.allFishCounter--;
            pointvalue++;
            //Debug.Log(pointvalue);
            //Debug.Log("be killed by: "+beKilledBy.name);
            //Debug.Log("Benefit: " + beKilledBy.WatchWallet());

        }
    }

    //Fishes catched by Web
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Web"))
        {
            if(Random.Range(0,2) < 1)
            {
                //máu của cá -= sát thương của Web
                bloodFish -= collision.gameObject.GetComponent<WebInfo>().rangePower;
                if(bloodFish == 0) //nếu cá bị kết liễu
                {
                    beKilledBy = collision.gameObject.GetComponent<WebInfo>().firer;
                }
            }

        }
    }
}
