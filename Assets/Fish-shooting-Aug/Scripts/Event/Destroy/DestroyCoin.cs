using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoin : MonoBehaviour
{
    //public string nameOfPlayer;
    private Transform SpawnPoint1, SpawnPoint2, SpawnPoint3, SpawnPoint4;

    public int speed = 20;

    // Use this for initialization
    void Start()
    {

        SpawnPoint1 = transform.Find("/CoinZone/Spawn1");
        SpawnPoint2 = transform.Find("/CoinZone/Spawn2");
        SpawnPoint3 = transform.Find("/CoinZone/Spawn3");
        SpawnPoint4 = transform.Find("/CoinZone/Spawn4");


    }

    // Update is called once per frame
    void Update()
    {
        
        switch (int.Parse(gameObject.GetComponent<CoinInfo>().firer.name.Substring(6, 1)))
        {
            case 1:
                transform.position = Vector3.MoveTowards(transform.position, SpawnPoint1.transform.position, speed * Time.deltaTime);
                break;
            case 2:
                transform.position = Vector3.MoveTowards(transform.position, SpawnPoint2.transform.position, speed * Time.deltaTime);
                break;
            case 3:
                transform.position = Vector3.MoveTowards(transform.position, SpawnPoint3.transform.position, speed * Time.deltaTime);
                break;
            case 4:
                transform.position = Vector3.MoveTowards(transform.position, SpawnPoint4.transform.position, speed * Time.deltaTime);
                break;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CoinSpawn")
        {
            Destroy(this.gameObject, 0.25f);

        }
    }
}
