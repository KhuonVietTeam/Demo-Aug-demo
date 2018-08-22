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
            ChangeGun(player);
            Debug.Log("player" + player.WatchBullet());
        }
        if (Input.GetKeyDown(AddKey))
        {
            player.AddBulletValue(5);
            ChangeGun(player);
            Debug.Log("player" + player.WatchBullet());
        }
    } // hàm tăng giảm dame của đạn
    public static void GetKeyToShoot(int orderPlayer,Player player, KeyCode ShootKey)
    {
        if (Input.GetKeyDown(ShootKey))
        {

            if (player.WatchBullet() > 0)
            {

                bullet = (GameObject)Instantiate(srcBullets[SelectBullet(player)], CannonManager.cannon[orderPlayer].transform.position, CannonManager.cannon[orderPlayer].transform.rotation);
                bullet.name = "bullet" + orderPlayer;
                bullet.transform.SetParent(bulletZone, true);
                bullet.GetComponent<BulletInfo>().firer = player; //fill .firer to who is shooted
                bullet.GetComponent<BulletInfo>().rangePower = player.WatchBullet(); //fill .rangePower to how many range of power
                EventManager.bulletseller.SellBullet(player); //tru tien
                //Debug.Log("player 1: " +player.WatchWallet());
            }

        }
    } // hàm bắn đạn
    static int SelectBullet(Player player)
    {
        if (player.WatchBullet() >= 150)
        {
            return 6;
        }
        else if(player.WatchBullet() >= 125)
        {
            return 5;
        }
        else if (player.WatchBullet() >= 100)
        {
            return 4;
        }
        else if (player.WatchBullet() >= 75)
        {
            return 3;
        }
        else if (player.WatchBullet() >= 50)
        {
            return 2;
        }
        else if (player.WatchBullet() >= 25)
        {
            return 1;
        }
            return 0;
    } // hàm thay đổi hình của súng
    static void ChangeGun(Player player) // hàm gọi class cannon thay đổi súng 
    {
        if (player.WatchBullet() >= 150)
        {
            CannonManager.ChangeGunPrefabs(GetIDFromName(player), 6);
        }
        else if (player.WatchBullet() >= 125)
        {
            CannonManager.ChangeGunPrefabs(GetIDFromName(player), 5);
        }
        else if (player.WatchBullet() >= 100)
        {
            CannonManager.ChangeGunPrefabs(GetIDFromName(player), 4);
        }
        else if (player.WatchBullet() >= 75)
        {
            CannonManager.ChangeGunPrefabs(GetIDFromName(player), 3);
        }
        else if (player.WatchBullet() >= 50)
        {
            CannonManager.ChangeGunPrefabs(GetIDFromName(player), 2);
        }
        else if (player.WatchBullet() >= 25)
        {
            CannonManager.ChangeGunPrefabs(GetIDFromName(player), 1);
        }else
        {
            CannonManager.ChangeGunPrefabs(GetIDFromName(player), 0);
        }
    }
    static int GetIDFromName(Player player) // lấy id từ thuộc tính name của player. cần thêm thuộc tính id cho player
    {
        if (player.name == "player1") { return 0; }
        if (player.name == "player2") { return 1; }
        if (player.name == "player3") { return 2; }
        return 3;
    }
}
