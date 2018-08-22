using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager:MonoBehaviour  {
    private static Transform bulletZone;
    public static GameObject[] srcBullets;
    private static GameObject bullet;

    private void Awake()
    {
        srcBullets = Resources.LoadAll<GameObject>("Bullets");

    }
    private void Start()
    {
        bulletZone = transform.Find("/CannonObject/bulletZone");

    }
    public static void GetKeyToChangeBullet(Player player,KeyCode SubKey, KeyCode AddKey)
    {
        if (Input.GetKeyDown(SubKey))
        {
            player.SubBulletValue(5);
            Debug.Log("play1 bullet: " + player.WatchBullet());
        }
        if (Input.GetKeyDown(AddKey))
        {
            player.AddBulletValue(5);
            Debug.Log("play1 bullet: " + player.WatchBullet());


        }
    }

    public static void GetKeyToShoot(int orderPlayer,Player player, KeyCode ShootKey)
    {
        if (Input.GetKeyDown(ShootKey))
        {

            if (player.WatchBullet() > 0)
            {
                bullet = (GameObject)Instantiate(srcBullets[0], CannonManager.cannon[orderPlayer].transform.position, CannonManager.cannon[orderPlayer].transform.rotation);
                bullet.name = "bullet" + orderPlayer;
                bullet.transform.SetParent(bulletZone, true);
                bullet.GetComponent<BulletInfo>().firer = player; //fill .firer to who is shooted
                bullet.GetComponent<BulletInfo>().rangePower = player.WatchBullet(); //fill .rangePower to how many range of power
                EventManager.bulletseller.SellBullet(player); //tru tien
                //Debug.Log("player 1: " +player.WatchWallet());
            }

        }




    }
}
