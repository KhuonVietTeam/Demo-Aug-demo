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
    private Transform SpawnPoint1, SpawnPoint2, SpawnPoint3, SpawnPoint4;
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
        SpawnPoint1 = transform.Find("/CoinZone/Spawn1");
        SpawnPoint2 = transform.Find("/CoinZone/Spawn2");
        SpawnPoint3 = transform.Find("/CoinZone/Spawn3");
        SpawnPoint4 = transform.Find("/CoinZone/Spawn4");

    }
    // Update is called once per frame
    void Update()
    {
        // phần cá bay về tổ
        switch (beKilledBy.name)
        {
            case "player1":
                transform.position = Vector3.Lerp(transform.position, SpawnPoint1.transform.position, 3 * Time.deltaTime);
                break;
            case "player2":
                transform.position = Vector3.Lerp(transform.position, SpawnPoint2.transform.position, 3 * Time.deltaTime);
                break;
            case "player3":
                transform.position = Vector3.Lerp(transform.position, SpawnPoint3.transform.position, 3 * Time.deltaTime);
                break;
            case "player4":
                transform.position = Vector3.Lerp(transform.position, SpawnPoint4.transform.position, 3 * Time.deltaTime);
                break;

        }
    }
    private IEnumerator Blink()
    {
        for (int i = 0; i < 2; i++) // blink 2 lần mỗi khi bị bắn
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.red; // tô cá màu đỏ
            yield return new WaitForSeconds(0.08f);
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.white; // tô cá màu trắng
            yield return new WaitForSeconds(0.08f);
        }
    } // làm cá blink khi bị bắn
    //Fishes catched by Web
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CoinSpawn" && this.gameObject.tag == "DeadFish") // cá có tag DeadFish va chạm với giỏ
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Web")) // cá va chạm với web
        {
            if (true /*Random.Range(0, 2) < 1*/)
            {
                //máu của cá -= sát thương của Web
                bloodFish -= collision.gameObject.GetComponent<WebInfo>().rangePower;
                Debug.Log(bloodFish);
                if (bloodFish < 1) //nếu cá bị kết liễu
                {
                    // tìm file move cá bơi lẻ sẽ mang script này
                    try
                    {
                        this.gameObject.GetComponent<Move>().isMove = false;
                    }
                    catch (System.Exception) { Debug.Log("deo sao day"); }
                    // tìm file movesin cá bơi theo đàn sẽ mang script này
                    try
                    {
                        this.gameObject.GetComponent<MoveSinGroup>().isMove = false;
                    }
                    catch (System.Exception) { Debug.Log("deo sao day"); }
                    this.gameObject.tag = "DeadFish"; // gắn tag cho cá thành DeadFish
                    beKilledBy = collision.gameObject.GetComponent<WebInfo>().firer;
                    FishDead();
                }
                else
                {
                    StartCoroutine(Blink());
                }
            }

        }
    }
    // cá quẩy vào bay về giỏ
    void FishDead()
    {
        ani.SetBool("dead", true); // set animation
        // Destroy(this.gameObject, 1);  //destroy this fish
        coin = Instantiate(srcCoin, transform.position, transform.rotation) as GameObject;
        coin.name = "coin";
        coin.transform.SetParent(CoinZone, true);
        coin.gameObject.GetComponent<CoinInfo>().firer = beKilledBy;
        EventManager.fishbuyer.BuyFish(beKilledBy, fish);
        //Debug.Log("be killed by: " + beKilledBy.name);
        //Debug.Log("Benefit: " + beKilledBy.WatchWallet());
    } // sử lý khi cá chết = khởi tạo tiền xác định người bắn va thực hiện cộng tiền
}