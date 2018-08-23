using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishShooted : MonoBehaviour
{
    public int bloodFish = 1;
    public Player beKilledBy;
    public int benefitValue;
    private GameObject srcCoin, coin;
    private Transform CoinZone;
    Fish fish;
    Animator ani;
    void Awake()
    {
        beKilledBy = new Player();
        benefitValue = bloodFish;  // Default: Gia tri fish = Máu cá
        srcCoin = Resources.Load<GameObject>("Coin/coinAni");
        fish = new Fish(this.gameObject.name, benefitValue);
        ani = gameObject.GetComponent<Animator>();

    }
    // Use this for initialization
    void Start()
    {

        CoinZone = transform.Find("/CoinZone");

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Fishes catched by Web
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Web"))
        {
            if (Random.Range(0, 2) < 1)
            {
                //máu của cá -= sát thương của Web
                bloodFish -= collision.gameObject.GetComponent<WebInfo>().rangePower;
                Debug.Log(bloodFish);
                if (bloodFish < 0) //nếu cá bị kết liễu
                {
                    try
                    {
                        this.gameObject.GetComponent<Move>().isMove = false;
                    }
                    catch (System.Exception) { Debug.Log("deo sao day"); }
                    try
                    {
                        this.gameObject.GetComponent<MoveSinGroup>().isMove = false;
                    }
                    catch (System.Exception) { Debug.Log("deo sao day"); }
                    this.gameObject.tag = "Untagged";
                    beKilledBy = collision.gameObject.GetComponent<WebInfo>().firer;
                    FishDead();
                    FishManager.allFishCounter--;
                }
            }

        }
    }
    void FishDead()
    {
        ani.SetBool("dead", true);
        Destroy(this.gameObject, 1);  //destroy this fish
        coin = Instantiate(srcCoin, transform.position, transform.rotation) as GameObject;
        coin.name = "coin";
        coin.transform.SetParent(CoinZone, true);
        coin.gameObject.GetComponent<CoinInfo>().firer = beKilledBy;
        EventManager.fishbuyer.BuyFish(beKilledBy, fish);

        //Debug.Log("be killed by: " + beKilledBy.name);
        //Debug.Log("Benefit: " + beKilledBy.WatchWallet());
    }
}