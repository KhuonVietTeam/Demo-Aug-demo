﻿using System.Collections;
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
            CannonManager.ChangeGun(player);
            Debug.Log("player" + player.WatchBullet());
        }
        if (Input.GetKeyDown(AddKey))
        {
            player.AddBulletValue(5);
            CannonManager.ChangeGun(player);
            Debug.Log("player" + player.WatchBullet());
        }
    } // hàm tăng giảm dame của đạn
    public static void GetKeyToShoot(int orderPlayer,Player player, KeyCode ShootKey)
    {
        if (Input.GetKeyDown(ShootKey))
        {

            if (player.WatchBullet() > 0 && player.WatchWallet() >0 && player.WatchWallet()>= player.WatchBullet())
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
            SoundManager.PlaySound("gun7");
            return 6;
        }
        else if(player.WatchBullet() >= 125)
        {
            SoundManager.PlaySound("gun6");
            return 5;
        }
        else if (player.WatchBullet() >= 100)
        {
            SoundManager.PlaySound("gun45");
            return 4;
        }
        else if (player.WatchBullet() >= 75)
        {
            SoundManager.PlaySound("gun45");
            return 3;
        }
        else if (player.WatchBullet() >= 50)
        {
            SoundManager.PlaySound("gun13");
            return 2;
        }
        else if (player.WatchBullet() >= 25)
        {
            SoundManager.PlaySound("gun13");
            return 1;
        }
        SoundManager.PlaySound("gun13");
        return 0;
    }
    
}
